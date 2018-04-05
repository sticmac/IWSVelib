using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VelibClient.Cli.Commands
{
    public class Subscribe : Command
    {
        public Subscribe() : base("subscribe") { }

        public override void Execute(params string[] args)
        {
            velibServiceEvents.SubscribeStationUpdated(args[0], args[1]);
        }
    }
}
