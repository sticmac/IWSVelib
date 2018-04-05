using IWSVelibLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IWSVelibEventsLib
{
    public interface IVelibServiceEvents
    {
        [OperationContract(IsOneWay = true)]
        void StationUpdated(string cityname, string stationname, int T, Station result);
    }
}
