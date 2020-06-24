using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace APIAutomationTestSuite
{
    public static class RestApiHelper
    {
        public static RestClient client;
        public static RestRequest restRequest;
        //public static string baseURL ="http://mydomain.com";
        //public static string baseURL = "https://reqres.in/";
        //public static string baseURL = "https://pokeapi.co/api/"; // v2/pokemon/ditto
        public static string baseURL = "https://jsonplaceholder.typicode.com/";
        public static RestClient SetUrl(string endpoint)
        {
            string url = Path.Combine(baseURL, endpoint); // Only Return /endpoint/
            //string url = baseURL + endpoint;
            Debug.Write(url+"\n");
            return client = new RestClient(url);
        }

        public static RestRequest CreateRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept","application/json");
            return restRequest;
        }
        //http://mydomain.com/userinformation/userid
        public static RestRequest CreateRequest(string userId)
        {
            var resource = userId;
            restRequest = new RestRequest(resource, Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }
        //http://mydomain.com/userinformation/userid/AccountInformation?account={accountNumber}
        public static RestRequest CreateRequest(string userId,long accountNumber)
        {
            var resource = userId + "/AccountInformation?account={accountNumber}";
            restRequest = new RestRequest(resource, Method.GET);
            restRequest.AddParameter("accountNumber",accountNumber,ParameterType.UrlSegment);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static RestRequest CreatePostRequest()
        {
            var userInfo = new Post();
            userInfo.userId = 2;
            userInfo.title = "Pal";
            userInfo.body = "Tej@mail.com";

            var resource = "";
            restRequest = new RestRequest(resource, Method.POST);
            restRequest.AddJsonBody(userInfo);
            //restRequest.AddBody(userInfo);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static IRestResponse GetResponse()
        {
            return client.Execute(restRequest);
        }


    }
}
