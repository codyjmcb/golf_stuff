using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using DataModels;

namespace Repositories
{
    public class GolfClubRepo : IItemsForRepository<GolfClub, Golfer>
    {
        const string ipAddress = "http://10.0.0.99/golfclub";
        const string golferClubAddress = "http://10.0.0.99/golfer/golfclubs";

        public bool Add(GolfClub x)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress);

            webRequest.Method = "POST";

            webRequest.ContentType = "application/json; charset=utf-8";

            using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
            {
                string json = "{\"golferID\":\"" + x._golferID + "\",\"clubID\":\"" + x._clubID +
                       "\",\"lie\":\"" + x._lie + "\",\"make\":\"" + x._make + "\",\"model\":\"" + x._model + "\"}";

                streamWriter.Write(json);
                streamWriter.Close();
            }

            var response = (HttpWebResponse)webRequest.GetResponse();

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var responseString = reader.ReadToEnd();

                if (responseString == "Success")
                {
                    return true;
                }
            }

            return false;
        }

        public bool AddFor(GolfClub x, Golfer y)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress);

            webRequest.Method = "DELETE";
            webRequest.Headers.Clear();
            webRequest.Headers.Add("uniqueID:" + id);

            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string jsonReturned = reader.ReadToEnd();

                    jsonReturned = jsonReturned.Replace("[", "");
                    jsonReturned = jsonReturned.Replace("]", "");

                    if (jsonReturned == "Success")
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool DeleteAllFor(Golfer x)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFor(GolfClub x, Golfer y)
        {
            throw new NotImplementedException();
        }

        public GolfClub Find(string id)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress);

            webRequest.Method = "GET";
            webRequest.Headers.Clear();
            webRequest.Headers.Add("uniqueID:" + id);

            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string jsonReturned = reader.ReadToEnd();

                    jsonReturned = jsonReturned.Replace("[", "");
                    jsonReturned = jsonReturned.Replace("]", "");

                    List<GolfClub> parsed = JsonExtensions.FromDelimitedJson<GolfClub>(new StringReader(jsonReturned)).ToList();

                    return parsed[0];
                }
            }
        }

        public IList<GolfClub> FindAll()
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress + "s"); //plural form

            webRequest.Method = "GET";

            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string jsonReturned = reader.ReadToEnd();

                    jsonReturned = jsonReturned.Replace("[", "");
                    jsonReturned = jsonReturned.Replace("]", "");

                    List<GolfClub> parsed = JsonExtensions.FromDelimitedJson<GolfClub>(new StringReader(jsonReturned)).ToList();

                    return parsed;
                }
            }
        }

        public IList<GolfClub> FindFor(Golfer x)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(golferClubAddress);

            webRequest.Method = "GET";
            webRequest.Headers.Clear();
            webRequest.Headers.Add("golferID:" + x._golferID);

            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string jsonReturned = reader.ReadToEnd();

                    jsonReturned = jsonReturned.Replace("[", "");
                    jsonReturned = jsonReturned.Replace("]", "");

                    List<GolfClub> parsed = JsonExtensions.FromDelimitedJson<GolfClub>(new StringReader(jsonReturned)).ToList();

                    return parsed;
                }
            }
        }

        public bool Update(GolfClub x)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress);

            webRequest.Method = "PUT";

            webRequest.ContentType = "application/json; charset=utf-8";

            using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
            {
                string json = "{\"golferID\":\"" + x._golferID + "\",\"uniqueID\":\"" + x._uniqueID + "\",\"clubID\":\"" + x._clubID +
                       "\",\"lie\":\"" + x._lie + "\",\"make\":\"" + x._make + "\",\"model\":\"" + x._model + "\"}";

                streamWriter.Write(json);
                streamWriter.Close();
            }

            var response = (HttpWebResponse)webRequest.GetResponse();

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var responseString = reader.ReadToEnd();

                if (responseString == "Success")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
