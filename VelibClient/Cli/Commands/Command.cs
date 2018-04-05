using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using VelibClient.VelibService;

namespace VelibClient.Cli.Commands
{
    /**
     * abstract Command class
     * defines a CLI command interface, according to Gamma's Command pattern
     */
    public abstract class Command
    {
        public string Name { get; set; }

        protected VelibServiceClient velibService;
        protected VelibServiceEvents.VelibServiceClient velibServiceEvents;
        
        public Command(string name)
        {
            this.Name = name;
            this.velibService = new VelibServiceClient();
            VelibServiceCallbackSink sink = new VelibServiceCallbackSink();
            InstanceContext iCntxt = new InstanceContext(sink);

            velibServiceEvents = new VelibServiceEvents.VelibServiceClient(iCntxt);
        }

        /**
         * General command to execute a method in the interactive CLI client.
         */
        public abstract void Execute(params String[] args);
    }
}
