using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelibClient.Cli.Commands
{
    public class Help : Command
    {
        public Help() : base("help") { }

        public override void Execute(params String[] args)
        {
            throw new NotImplementedException();
        }
    }
}
