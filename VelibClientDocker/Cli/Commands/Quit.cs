using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelibClientDotNetCore.Cli.Commands
{
    /**
     * Quits client.
     */
    public class Quit : Command
    {
        public Quit() : base("quit") { }

        public override void Execute(params String[] args)
        {
            Environment.Exit(0);
        }
    }
}
