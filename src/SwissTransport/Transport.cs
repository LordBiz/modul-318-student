using System.IO;
using System.Net;
using Newtonsoft.Json;
using System;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var message = new StreamReader(responseStream).ReadToEnd();
                var stations = JsonConvert.DeserializeObject<Stations>(message);
                return stations;
            }

            return null;
        }

        /// <summary>
        /// Erstellt ein Objekt mit allen Abfahrten einer Station.
        /// Es wurde das Datum und die Zeit hinzugefügt
        /// </summary>
        public StationBoardRoot GetStationBoard(string station, DateTime Date, DateTime Time)
        {
            try
            {
                string date = Date.ToString("yyyy-MM-dd");
                string time = Time.ToString("HH:mm");
                var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?station=" + station + "&date=" + Date + "" + Time);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var readToEnd = new StreamReader(responseStream).ReadToEnd();
                    var stationboard = JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                    return stationboard;
                }

                return null;

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Erstellt eine Objekt mit allen Verbindungen zwischen zwei Stationen.
        /// Es wurden Datum, Zeit und isArrivalTime hinzugefügt
        /// </summary>
        public Connections GetConnections(string fromStation, string toStattion, DateTime Date, DateTime Time, bool isArrivalTime)
        {
            try
            {
                string date = Date.ToString("yyyy-MM-dd");
                string time = Time.ToString("HH:mm");
                string arrival = "0";
                if (isArrivalTime)
                    arrival = "1";
                var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion + "&date=" + date + "&time=" + time + "&isArrivalTime" + arrival);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var readToEnd = new StreamReader(responseStream).ReadToEnd();
                    var connections = JsonConvert.DeserializeObject<Connections>(readToEnd);
                    return connections;
                }

                return null;

            }
            catch (Exception)
            {
                throw;
            }
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;

            return request;
        }
    }
}
