using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibClient.VelibService;
using VelibClient.Cli;

namespace VelibClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Shell shell = new Shell("JCDecaux> ");
            shell.Execute();
        }
    }
}
