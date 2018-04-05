using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibClient.VelibServiceEvents;

namespace VelibClient
{
    class VelibServiceCallbackSink : VelibServiceEvents.IVelibServiceCallback
    {
        public void StationUpdated(Station result)
        {
            Console.WriteLine(result.Name + " – " + result.Address);
            Console.WriteLine();
            Console.WriteLine("Vélos disponibles : " + result.Available_bikes + "/" + result.Bike_stands);
        }
    }
}
