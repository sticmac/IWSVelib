using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IWSVelibEventsLib
{
    [ServiceContract(CallbackContract = typeof(IVelibServiceEvents))]
    public interface IVelibService
    {
        [OperationContract]
        void GetStation(string cityname, string stationname);

        [OperationContract]
        void SubscribeStationUpdated();
    }
}
