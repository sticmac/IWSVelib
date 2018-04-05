using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibClientEvents.VelibServiceEvents;

namespace VelibClientEvents
{
    class VelibServiceCallbackSink : IVelibServiceCallback
    {
        public void StationUpdated(Station result)
        {
            Console.WriteLine(result.Name + " – " + result.Address);
            Console.WriteLine();
            Console.WriteLine("Vélos disponibles : " + result.Available_bikes + "/" + result.Bike_stands);
        }
    }
}
