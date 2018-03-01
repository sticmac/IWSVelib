using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IWSVelib
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Service1 : IService1
    {
        public Service1()
        {
            
        }

        public int GetFreeByciclesAt(string city, string stationName)
        {
            throw new NotImplementedException();
        }

        public int GetPlacesAt(string city, string stationName)
        {
            throw new NotImplementedException();
        }
    }
}
