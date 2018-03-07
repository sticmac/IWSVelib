using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibClient.VelibService;

namespace VelibClient
{
    class Program
    {
        static void Main(string[] args)
        {
            VelibServiceClient velibService = new VelibServiceClient();

            Console.WriteLine("Quelle ville ?");
            string city = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Quelle station ?");
            string stationName = Console.ReadLine();
            Console.WriteLine();

            Station station = velibService.GetStation(city, stationName);

            Console.WriteLine(station.Name + " – " + station.Address);
            Console.WriteLine();
            Console.WriteLine("Vélos disponibles : " + station.Available_bikes + "/" + station.Bike_stands);
        }
    }
}
