using DataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Repositories
{
    public class GolfersRepo : IRepository<Golfer>
    {
        const string ipAddress = "http://10.0.0.99/golfer";

        public bool Add(Golfer x)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress);

            webRequest.Method = "POST";

            webRequest.ContentType = "application/json; charset=utf-8";

            using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
            {
                string json = "{\"golferID\":\"" + x._golferID + "\",\"firstName\":\"" + x._firstName +
                    "\",\"middleInitial\":\"" + x._middleInitial + "\",\"lastName\":\"" + x._lastName + "\",\"handicap\":\"" +
                    x._handicap + "\"}";

                streamWriter.Write(json);
            }

            var response = (HttpWebResponse)webRequest.GetResponse();

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var responseString = reader.ReadToEnd();

                if (responseString == "Add Golfer")
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
            webRequest.Headers.Add("golferID:" + id);

            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string jsonReturned = reader.ReadToEnd();

                    jsonReturned = jsonReturned.Replace("[", "");
                    jsonReturned = jsonReturned.Replace("]", "");

                    if (jsonReturned == "Delete Golfer")
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public Golfer Find(string id)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress);

            webRequest.Method = "GET";
            webRequest.Headers.Clear();
            webRequest.Headers.Add("golferId:" + id);

            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string jsonReturned = reader.ReadToEnd();

                    Golfer ret = new Golfer(null, null, 'z', null, 0);
                    ret._golferID = jsonReturned;
                    return ret;
                }
            }
        }

        public IList<Golfer> FindAll()
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

                    List<Golfer> parsed = new List<Golfer>();
                    parsed.Add(new Golfer("12345", "Cody", 'J', "McBride", 0));
                    parsed.Add(new Golfer("67890", "Cody", 'J', "McBride", 0));

                    return parsed;
                }
            }
        }

        public bool Update(Golfer x)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress);

            webRequest.Method = "PUT";

            webRequest.ContentType = "application/json; charset=utf-8";

            using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
            {
                string json = "{\"golferID\":\"" + x._golferID + "\",\"firstName\":\"" + x._firstName +
                    "\",\"middleInitial\":\"" + x._middleInitial + "\",\"lastName\":\"" + x._lastName + "\",\"handicap\":\"" +
                    x._handicap + "\"}";

                streamWriter.Write(json);
            }

            var response = (HttpWebResponse)webRequest.GetResponse();

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var responseString = reader.ReadToEnd();

                if (responseString == "Update Golfer")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
