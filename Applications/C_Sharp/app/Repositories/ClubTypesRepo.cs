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
    public class ClubTypeRepo : IRepository<ClubType>
    {
        const string ipAddress = "http://10.0.0.99/clubtype";

        public bool Add(ClubType x)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress);

            webRequest.Method = "POST";

            webRequest.ContentType = "application/json; charset=utf-8";

            using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
            {
                string json = "{\"clubName\":\"" + x._clubName + "\",\"uniqueId\":\"" + x._uniqueID + "\"}";

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

        public bool Delete(string id)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress);

            webRequest.Method = "DELETE";
            webRequest.Headers.Clear();
            webRequest.Headers.Add("uniqueId:" + id);

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

        public ClubType Find(string id)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress);

            webRequest.Method = "GET";
            webRequest.Headers.Clear();
            webRequest.Headers.Add("uniqueId:" + id);

            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string jsonReturned = reader.ReadToEnd();

                    jsonReturned = jsonReturned.Replace("[", "");
                    jsonReturned = jsonReturned.Replace("]", "");

                    List<ClubType> parsed = JsonExtensions.FromDelimitedJson<ClubType>(new StringReader(jsonReturned)).ToList();

                    return parsed[0];
                }
            }
        }

        public IList<ClubType> FindAll()
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

                    List<ClubType> parsed = JsonExtensions.FromDelimitedJson<ClubType>(new StringReader(jsonReturned)).ToList();

                    return parsed;
                }
            }
        }

        public bool Update(ClubType x)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress);

            webRequest.Method = "PUT";

            webRequest.ContentType = "application/json; charset=utf-8";

            using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
            {
                string json = "{\"clubName\":\"" + x._clubName + "\",\"uniqueId\":\"" + x._uniqueID + "\"}";

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
