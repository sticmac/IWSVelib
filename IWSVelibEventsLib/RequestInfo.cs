using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWSVelibEventsLib
{
    class RequestInfo
    {
        public string CityName { get; private set; }
        public string StationName { get; private set;  }

        public RequestInfo(string cityname, string stationname)
        {
            this.CityName = cityname;
            this.StationName = stationname;
        }

        public override bool Equals(object rhs)
        {
            RequestInfo rhsRequestInfo = rhs as RequestInfo;
            if (rhsRequestInfo == null) return false;

            return this.Equals(rhsRequestInfo);
        }

        public bool Equals(RequestInfo requestInfo)
        {
            return this.CityName.Equals(requestInfo.CityName) && this.StationName.Equals(requestInfo.StationName);
        }

        public override int GetHashCode()
        {
            return (CityName.GetHashCode() * 397) ^ StationName.GetHashCode();
        }
    }
}
