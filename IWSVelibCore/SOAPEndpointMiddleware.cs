using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceModel.Channels;
using Microsoft.AspNetCore.Http;
using System.ServiceModel;
using System.Reflection;
using System.Runtime.Serialization;

namespace IWSVelibCore
{
    public class SOAPEndpointMiddleware
    {
        private readonly RequestDelegate next;
        private readonly Type serviceType;
        private readonly string endpointPath;
        private readonly MessageEncoder messageEncoder;
        private readonly ServiceDescription service;

        public SOAPEndpointMiddleware(RequestDelegate next, Type serviceType, string path, MessageEncoder messageEncoder)
        {
            this.next = next;
            this.serviceType = serviceType;
            this.endpointPath = path;
            this.messageEncoder = messageEncoder;
            this.service = new ServiceDescription(this.serviceType);
        }

        public async Task Invoke(HttpContext httpContext, IServiceProvider serviceProvider)
        {
            if (httpContext.Request.Path.Equals(endpointPath, StringComparison.Ordinal))
            {
                Message responseMessage;

                // Read request message
                var requestMessage = messageEncoder.ReadMessage(httpContext.Request.Body, 0x10000, httpContext.Request.ContentType);

                var soapAction = httpContext.Request.Headers["SOAPAction"].ToString().Trim('\"');
                if (!string.IsNullOrEmpty(soapAction))
                {
                    requestMessage.Headers.Action = soapAction;
                }

                var operation = service.Operations.Where(o => o.SoapAction.Equals(requestMessage.Headers.Action, StringComparison.Ordinal)).FirstOrDefault();
                if (operation == null)
                {
                    throw new InvalidOperationException($"No operation found for specified action: {requestMessage.Headers.Action}");
                }

                // Get service type
                var serviceInstance = serviceProvider.GetService(service.ServiceType);

                // Get operation arguments from message
                var arguments = GetRequestArguments(requestMessage, operation);

                // Invoke Operation method
                var responseObject = operation.DispatchMethod.Invoke(serviceInstance, arguments.ToArray());

                // Create response message
                var resultName = operation.DispatchMethod.ReturnParameter.GetCustomAttribute<MessageParameterAttribute>()?.Name ?? operation.Name + "Result";
                var bodyWriter = new ServiceBodyWriter(operation.Contract.Namespace, operation.Name + "Response", resultName, responseObject);
                responseMessage = Message.CreateMessage(messageEncoder.MessageVersion, operation.ReplyAction, bodyWriter);

                httpContext.Response.ContentType = httpContext.Request.ContentType; // _messageEncoder.ContentType;
                httpContext.Response.Headers["SOAPAction"] = responseMessage.Headers.Action;

                messageEncoder.WriteMessage(responseMessage, httpContext.Response.Body);
            }
            else
            {
                await next(httpContext);
            }
        }

        private object[] GetRequestArguments(Message requestMessage, OperationDescription operation)
        {
            var parameters = operation.DispatchMethod.GetParameters();
            var arguments = new List<object>();

            // Deserialize request wrapper and object
            using (var xmlReader = requestMessage.GetReaderAtBodyContents())
            {
                // Find the element for the operation's data
                xmlReader.ReadStartElement(operation.Name, operation.Contract.Namespace);
                
                for (int i = 0; i < parameters.Length; i++)
                {
                    var parameterName = parameters[i].GetCustomAttribute<MessageParameterAttribute>()?.Name ?? parameters[i].Name;
                    xmlReader.MoveToStartElement(parameterName, operation.Contract.Namespace);
                    if (xmlReader.IsStartElement(parameterName, operation.Contract.Namespace))
                    {
                        var serializer = new DataContractSerializer(parameters[i].ParameterType, parameterName, operation.Contract.Namespace);
                        arguments.Add(serializer.ReadObject(xmlReader, verifyObjectName: true));
                    }
                }
            }

            return arguments.ToArray();
        }
    }
}
