using ATicket.Module;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATicket.RestApiClent
{
    public static class RestHelper
    {
        static string _url = "http://47.96.123.158:8080/ShowCoreWeb";
        //static string _url = "https://localhost:44374";
        static RestClient Client = new RestClient(_url);


        public static Dictionary<string, List<Showstarts>> GetShow()
        {
            var Request = new RestRequest("/api/Show", Method.POST);
            Request.AddParameter("name", "admin");
            IRestResponse Response = Client.Execute(Request);
            var Content = Response.Content;

            JObject bb = (JObject)JsonConvert.DeserializeObject(Content);
            bool status = (bool)bb["status"];
            if (status == true)
            {

                JArray JoldShow = (JArray)bb["oldShow"];
                JArray JnewShow = (JArray)bb["newShow"];


                List<Showstarts> oldShow = new List<Showstarts>();
                List<Showstarts> newShow = new List<Showstarts>();
                foreach (var a in JoldShow)
                {
                    Showstarts show = new Showstarts();
                    string op = JsonConvert.SerializeObject(a);
                    show = JsonConvert.DeserializeObject<Showstarts>(op);

                    oldShow.Add(show);
                }

                foreach (var a in JnewShow)
                {
                    Showstarts show = new Showstarts();
                    string op = JsonConvert.SerializeObject(a);
                    show = JsonConvert.DeserializeObject<Showstarts>(op);

                    newShow.Add(show);
                }
                Dictionary<string, List<Showstarts>> keys = new Dictionary<string, List<Showstarts>>();
                keys.Add("oldShow", oldShow);
                keys.Add("newShow", newShow);
                return keys;
            }
            else { return null; }
        }


        public static List<Monitor> GetMonitor(string username)
        {

            var Client = new RestClient(_url);
            var Request = new RestRequest("/api/Monitor/", Method.GET);
            Request.AddParameter("username", username);
            IRestResponse Response = Client.Execute(Request);
            var Content = Response.Content;

            List<Monitor> m = JsonConvert.DeserializeObject<List<Monitor>>(Content);
            return m;
        }

        public static bool DeleteMonitor(Monitor m)
        {
            var Client = new RestClient(_url);
            var Request = new RestRequest("/api/Monitor", Method.DELETE);
            //Request.RequestFormat = DataFormat.Json;
            Request.AddJsonBody(m);
            IRestResponse Response = Client.Execute(Request);
            var Content = Response.Content;

            JObject bb = (JObject)JsonConvert.DeserializeObject(Content);
            bool status = (bool)bb["status"];
            return status;
        }

        public static bool AddMonitor(Monitor m)
        {
            var Client = new RestClient(_url);
            var Request = new RestRequest("/api/Monitor", Method.POST);
            Request.RequestFormat = DataFormat.Json;

            Request.AddJsonBody(m);

            IRestResponse Response = Client.Execute(Request);
            var Content = Response.Content;

            JObject bb = (JObject)JsonConvert.DeserializeObject(Content);
            bool status = (bool)bb["status"];
            return status;
        }
    }
}
