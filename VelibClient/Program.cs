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

            Station[] stations = velibService.GetStations("Toulouse");

            foreach(Station station in stations)
            {
                Console.WriteLine(station.Name);
            }
            Console.ReadLine();
        }
    }
}
