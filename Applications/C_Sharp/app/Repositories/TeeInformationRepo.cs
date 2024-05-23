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
    public class TeeInformationRepo : IItemsForRepository<TeeInformation, GolfCourse>
    {
        public const string ipAddress_teeInformation = "http://10.0.0.99/teeinformation";
        public const string ipAddress_teeInformation_Course = "http://10.0.0.99/golfcourse/teeinformation";

        public bool Add(TeeInformation x)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress_teeInformation);

            webRequest.Method = "POST";

            webRequest.ContentType = "application/json; charset=utf-8";

            using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
            {
                string json = "{\"courseID\":\"" + x._courseID + "\",\"teeName\":\"" + x._teeName +
                       "\",\"yardage\":\"" + x._yardage + "\",\"slope\":\"" + x._slope + "\",\"rating\":\"" + x._rating + "\"}";

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

        public bool AddFor(TeeInformation x, GolfCourse y)
        {
            throw new NotImplementedException("TeeInformationRepo.AddFor(TeeInformation x, GolfCourse y");
        }

        public bool Delete(string id)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress_teeInformation);

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

        public bool DeleteAllFor(GolfCourse x)
        {
            throw new NotImplementedException("TeeInformationRepo.DeleteAllFor(GolfCourse x");
            /*
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress_teeInformation_Course);

            webRequest.Method = "DELETE";
            webRequest.Headers.Clear();
            webRequest.Headers.Add("courseID:" + x._courseID);

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
            */
        }

        public bool DeleteFor(TeeInformation x, GolfCourse y)
        {
            throw new NotImplementedException("TeeInformationRepo.DeleteFor(TeeInformation x, GolfCourse y");
        }

        public TeeInformation Find(string id)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress_teeInformation);

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

                    List<TeeInformation> parsed = JsonExtensions.FromDelimitedJson<TeeInformation>(new StringReader(jsonReturned)).ToList();

                    return parsed[0];
                }
            }
        }

        public IList<TeeInformation> FindAll()
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress_teeInformation + "s"); //plural form

            webRequest.Method = "GET";

            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string jsonReturned = reader.ReadToEnd();

                    jsonReturned = jsonReturned.Replace("[", "");
                    jsonReturned = jsonReturned.Replace("]", "");

                    List<TeeInformation> parsed = JsonExtensions.FromDelimitedJson<TeeInformation>(new StringReader(jsonReturned)).ToList();

                    return parsed;
                }
            }
        }

        public IList<TeeInformation> FindFor(GolfCourse x)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress_teeInformation_Course);

            webRequest.Method = "GET";
            webRequest.Headers.Clear();
            webRequest.Headers.Add("courseID:" + x._courseID);

            using (WebResponse response = webRequest.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string jsonReturned = reader.ReadToEnd();

                    jsonReturned = jsonReturned.Replace("[", "");
                    jsonReturned = jsonReturned.Replace("]", "");

                    List<TeeInformation> parsed = JsonExtensions.FromDelimitedJson<TeeInformation>(new StringReader(jsonReturned)).ToList();

                    return parsed;
                }
            }
        }

        public bool Update(TeeInformation x)
        {
            HttpWebRequest webRequest;

            webRequest = (HttpWebRequest)WebRequest.Create(ipAddress_teeInformation);

            webRequest.Method = "PUT";

            webRequest.ContentType = "application/json; charset=utf-8";

            using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
            {
                string json = "{\"uniqueID\":\"" + x._uniqueID + "\",\"courseID\":\"" + x._courseID + "\",\"teeName\":\"" + x._teeName +
                       "\",\"yardage\":\"" + x._yardage + "\",\"slope\":\"" + x._slope + "\",\"rating\":\"" + x._rating + "\"}";

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
