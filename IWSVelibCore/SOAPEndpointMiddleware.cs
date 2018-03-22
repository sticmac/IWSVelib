using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceModel.Channels;
using Microsoft.AspNetCore.Http;

namespace IWSVelibCore
{
    public class SOAPEndpointMiddleware
    {
        private readonly RequestDelegate next;
        private readonly Type serviceType;
        private readonly string endpointPath;
        private readonly MessageEncoder messageEncoder;
        private readonly ServiceDescription service;

        public SOAPEndpointMiddleware(RequestDelegate next, Type type, string path, MessageEncoder messageEncoder)
        {
            this.next = next;
            this.serviceType = type;
            this.endpointPath = path;
            this.messageEncoder = messageEncoder;
            this.service = new ServiceDescription(type);
        }

        public async Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine($"Request for {httpContext.Request.Path} received ({httpContext.Request.ContentLength ?? 0} bytes)");

            // Call the next middleware delegate in the pipeline 
            await next.Invoke(httpContext);
        }
    }
}
