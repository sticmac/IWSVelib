using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using IWSVelibLib;

namespace IWSVelibEventsLib
{
    public class VelibService : IVelibService
    {
        static Action<string, string, int, Station> event1 = delegate { };

        public void GetStation(string cityname, string stationname)
        {
            Station s = (new IWSVelibLib.VelibService()).GetStation(cityname, stationname);
            event1(cityname, stationname, 0, s);
        }

        public void SubscribeStationUpdated()
        {
            IVelibServiceEvents subscriber =
                OperationContext.Current.GetCallbackChannel<IVelibServiceEvents>();
            event1 += subscriber.StationUpdated;
        }
    }
}