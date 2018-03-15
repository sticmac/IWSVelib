using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IWSVelib
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IVelibService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IVelibService
    {
        [OperationContract]
        Station[] GetStations(string city);
        [OperationContract]
        Station GetStation(string city, string stationName);
        [OperationContract]
        Contract[] GetContracts();
    }

}
