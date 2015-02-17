using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Web;

using Newtonsoft.Json;

namespace MovieApp.Models
{
    public class Query
    {
        private System.Collections.Specialized.NameValueCollection Inputs
            = new System.Collections.Specialized.NameValueCollection();


        public string Url = "http://api.rottentomatoes.com/api/public/v1.0.json?apikey=";
        public string Method = "post";
        public string FormName = "query";

        public void Add(string name, string value)
        {
            Inputs.Add(name, value);
        }

        public void Post()
        {
            System.Web.HttpContext.Current.Response.Clear();
            System.Web.HttpContext.Current.Response.Write("");
        }
    


    


        // Set up query to rotten tomatoes API 
        // private HttpWebRequest request = WebRequest.Create("");

    }

    
}