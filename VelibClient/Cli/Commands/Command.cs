using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibClient.VelibService;

namespace VelibClient.Cli.Commands
{
    public abstract class Command
    {
        public string Name { get; set; }

        private VelibServiceClient velibService;
        
        public Command(string name)
        {
            this.Name = name;
            this.velibService = new VelibServiceClient();
        }

        /**
         * General command to execute a method in the interactive CLI client.
         */
        public abstract void Execute(params String[] args);
    }
}
