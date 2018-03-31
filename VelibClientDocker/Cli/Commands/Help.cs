using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelibClientDotNetCore.Cli.Commands
{
    public class Help : Command
    {
        public Help() : base("help") { }

        public override void Execute(params String[] args)
        {
            Console.WriteLine("JC Decaux Velib Client");
            Console.WriteLine("par Julien Lemaire");
            Console.WriteLine("");
            Console.WriteLine("- help : affiche ce message");
            Console.WriteLine("- list <city> : liste les stations disponibles dans la ville <city>");
            Console.WriteLine("- station <city> <stationname> : affiche le nombre de velibs disponibles dans la station correspondant au nom <stationname> de la ville <city>");
            Console.WriteLine("- quit : ferme ce programme");
        }
    }
}
