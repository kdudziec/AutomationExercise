using APITesting.DataModels;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace APITesting
{
    public static class APIWorkshop
    {
        public static RestClient restClient;
        public static IRestResponse response;
        public static dynamic output;


        public static void SetUrl(string url)
        {
            restClient = new RestClient(url);
        }

        public static void CreateGetRequest()
        {
            var restRequest = new RestRequest(Method.GET);
            restRequest.RequestFormat = DataFormat.Json;
            response = restClient.Execute(restRequest);
        }

        public static void CreateEmptyPostRequest()
        {
            var restRequest = new RestRequest(Method.POST);
            restRequest.RequestFormat = DataFormat.Json;
            response = restClient.Execute(restRequest);
        }

        public static void CreatePostRequest(string key1, string value1)
        {
            var restRequest = new RestRequest(Method.POST);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddParameter(key1, value1);
            response = restClient.Execute(restRequest);
        }

        public static void CreatePostRequest(string key1, string value1, string key2, string value2)
        {
            var restRequest = new RestRequest(Method.POST);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddParameter(key1, value1);
            restRequest.AddParameter(key2, value2);
            response = restClient.Execute(restRequest);
        }

        public static void CreateEmptyPutRequest()
        {
            var restRequest = new RestRequest(Method.PUT);
            restRequest.RequestFormat = DataFormat.Json;
            response = restClient.Execute(restRequest);
        }

        public static void CreateDeleteRequest()
        {
            var restRequest = new RestRequest(Method.DELETE);
            restRequest.RequestFormat = DataFormat.Json;
            response = restClient.Execute(restRequest);
        }


        public static void GetOutput<DTO>()
        {
            var content = response.Content;
            output = JsonConvert.DeserializeObject<DTO>(content);
        }


    }
}
