using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibClientDotNetCore.VelibServiceDotNetCore;

namespace VelibClientDotNetCore.Cli.Commands
{
    /**
     * List the stations for a given city.
     */
    public class StationBikes : Command
    {
        public StationBikes() : base("station") { }

        public override void Execute(params String[] args)
        {
            /*args: 0 -> contract city name
             *      1 -> station name
             */
            Station station = velibService.GetStation(args[0], args[1]);
            
            if (station == null)
            {
                //city or station name isn't recognized…
                Console.WriteLine("Erreur : Ville ou nom de station non reconnu.");
                return;
            }

            Console.WriteLine(station.Name + " – " + station.Address);
            Console.WriteLine();
            Console.WriteLine("Vélos disponibles : " + station.Available_bikes + "/" + station.Bike_stands);
        }
    }
}
