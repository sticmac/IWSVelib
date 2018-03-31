using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibClientDotNetCore.VelibServiceDotNetCore;
using VelibClientDotNetCore.Cli;

namespace VelibClientDotNetCore
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
