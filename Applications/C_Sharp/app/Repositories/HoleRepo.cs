using DataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class HoleRepo : IItemsForRepository<Hole, TeeInformation>
    {
        public const string ipAddress = "http://10.0.0.99/hole";
        public const string ipAddress2 = "http://10.0.0.99/teeinformation/holes";

        public bool Add(Hole x)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress);

            webRequest.Method = "POST";

            webRequest.ContentType = "application/json; charset=utf-8";

            using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
            {
                string json = "{\"teeID\":\"" + x._teeID + "\",\"holeNumber\":\"" + x._holeNumber +
                    "\",\"yardage\":\"" + x._yardage + "\",\"par\":\"" + x._par + "\",\"handicapRating\":\"" + x._handicapRating + "\"}";

                streamWriter.Write(json);
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

        public bool AddFor(Hole x, TeeInformation y)
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

                    if (jsonReturned == "Success")
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool DeleteAllFor(TeeInformation x)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFor(Hole x, TeeInformation y)
        {
            throw new NotImplementedException();
        }

        public Hole Find(string id)
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

                    List<Hole> parsed = JsonExtensions.FromDelimitedJson<Hole>(new StringReader(jsonReturned)).ToList();

                    return parsed[0];
                }
            }
        }

        public IList<Hole> FindAll()
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

                    List<Hole> parsed = JsonExtensions.FromDelimitedJson<Hole>(new StringReader(jsonReturned)).ToList();

                    return parsed;
                }
            }
        }

        public IList<Hole> FindFor(TeeInformation x)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress2);

            webRequest.Method = "GET";
            webRequest.Headers.Clear();
            webRequest.Headers.Add("teeID:" + x._uniqueID);

            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string jsonReturned = reader.ReadToEnd();

                    jsonReturned = jsonReturned.Replace("[", "");
                    jsonReturned = jsonReturned.Replace("]", "");

                    List<Hole> parsed = JsonExtensions.FromDelimitedJson<Hole>(new StringReader(jsonReturned)).ToList();

                    return parsed;
                }
            }
        }

        public bool Update(Hole x)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress);

            webRequest.Method = "PUT";

            webRequest.ContentType = "application/json; charset=utf-8";

            using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
            {
                string json = "{\"teeID\":\"" + x._teeID + "\",\"uniqueID\":\"" + x._uniqueID + "\",\"holeNumber\":\"" + x._holeNumber +
                    "\",\"yardage\":\"" + x._yardage + "\",\"par\":\"" + x._par + "\",\"handicapRating\":\"" + x._handicapRating + "\"}";

                streamWriter.Write(json);
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
