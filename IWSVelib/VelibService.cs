﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Web;
using System.ServiceModel;
using System.Text;
using Newtonsoft.Json;

namespace IWSVelibLib
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "VelibService" à la fois dans le code et le fichier de configuration.
    public class VelibService : IVelibService
    {
        private static string APIKEY = "b2fbf7cacc5a085a33c450fc1537a14b17961c6b";

        public VelibService()
        {
            
        }

        public Station GetStation(string city, string stationName)
        {
            Station[] stations;
            try
            {
                stations = GetStations(city);
                if (stations == null) return null;
            }
            catch (WebException e)
            {
                return null;
            }

            foreach(Station station in stations)
            {
                if (station.Name.Contains(stationName.ToUpper()))
                {
                    return station;
                }
            }

            return null;
        }

        public Station[] GetStations(string city)
        {
            string response = Request("https://api.jcdecaux.com/vls/v1/stations?contract=" + city + "&apiKey=" + APIKEY);
           
            return response == null ? null : JsonConvert.DeserializeObject<Station[]>(response);
        }

        public Contract[] GetContracts()
        {
            string response = Request("https://api.jcdecaux.com/vls/v1/contracts?apiKey=" + APIKEY);

            return JsonConvert.DeserializeObject<Contract[]>(response);
        }

        private string Request(string URL)
        {
            WebRequest request = WebRequest.Create(URL);
            WebResponse response;
            try
            {
                response = request.GetResponse();
            }
            catch (WebException e)
            {
                return null;
            }

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            response.Close();

            return responseFromServer;
        }
    }
}
