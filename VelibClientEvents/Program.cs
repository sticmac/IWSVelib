using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VelibClientEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            VelibServiceCallbackSink sink = new VelibServiceCallbackSink();
            InstanceContext iCntxt = new InstanceContext(sink);

            VelibServiceEvents.VelibServiceClient objClient = new VelibServiceEvents.VelibServiceClient(iCntxt);

            objClient.SubscribeStationUpdated();

            objClient.GetStation("toulouse", "metro");
            objClient.GetStation("lyon", "metro");
        }
    }
}
