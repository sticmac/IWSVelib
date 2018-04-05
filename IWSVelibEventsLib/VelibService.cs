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
        static Dictionary<RequestInfo, Action<Station>> events = new Dictionary<RequestInfo, Action<Station>>();

        public void GetStation(string cityname, string stationname)
        {
            RequestInfo ri = new RequestInfo(cityname, stationname);
            Station s = (new IWSVelibLib.VelibService()).GetStation(cityname, stationname);
            Action<Station> targets;
            if (events.TryGetValue(ri, out targets))
            {
                targets(s);
            }
        }

        public void SubscribeStationUpdated(string cityname, string stationname)
        {
            IVelibServiceEvents subscriber =
                OperationContext.Current.GetCallbackChannel<IVelibServiceEvents>();
            RequestInfo ri = new RequestInfo(cityname, stationname);
            Action<Station> targets;
            if (events.TryGetValue(ri, out targets))
            {
                targets += subscriber.StationUpdated;
                Console.WriteLine(events[ri]);
            }
            else
            {
                targets = delegate { };
                targets += subscriber.StationUpdated;
                events.Add(ri, targets);
                Console.WriteLine(events.Keys);
                Console.WriteLine(events[ri]);
            }
        }
    }
}