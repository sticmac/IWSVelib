using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibClient.VelibService;

namespace VelibClient.Cli.Commands
{
    /**
     * List stations availables for a given city
     */
    public class ListStations : Command
    {
        public ListStations() : base("list") { }

        public override void Execute(params String[] args)
        {
            //first argument is the city contract name
            if (args.Length > 0)
            {
                string city = String.Join(" ", args);

                Station[] stations = velibService.GetStations(city);
                if (stations == null) //city isn't recognized…
                {
                    Console.WriteLine("Erreur : Ville non reconnue.");
                    return;
                }
                
                foreach (Station station in stations)
                {
                    Console.WriteLine(station.Name);
                }
            }
        }
    }
}
