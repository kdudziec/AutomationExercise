using APITesting.DataModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Deserializers;

namespace APITesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void API1_GetAllProductsList()
        {
            var restClient = new RestClient("https://automationexercise.com/api/productsList");
            
            var restRequest = new RestRequest(Method.GET);
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var output = JsonConvert.DeserializeObject<AllProductsList>(content);
            Assert.That(output.responseCode, Is.EqualTo(200));

            List<string> productNames = new List<string>();
            int i = 0;
            foreach(var product in output.products)
            {
                productNames.Add(output.products[i].name);
                i++;
            }

            foreach(var productName in productNames)
            {
                Console.WriteLine(productName);
            }

        }

        [Test]
        public void API2_POSTToAllProductsList() 
        {
            RestClient restClient = new RestClient("https://automationexercise.com/api/productsList");
            var restRequest = new RestRequest(Method.POST);
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;
            var output = JsonConvert.DeserializeObject<AllProductsList>(content);

            Assert.That(output.responseCode, Is.EqualTo(405));
            Assert.That(output.message, Is.EqualTo("This request method is not supported."));

        }

        [Test]
        public void API3_GetAllBrandsList()
        {
            var restClient = new RestClient("https://automationexercise.com/api/brandsList");

            var restRequest = new RestRequest(Method.GET);
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var statusCode = (int)response.StatusCode;
            Assert.That(statusCode, Is.EqualTo(200));

            var output = JsonConvert.DeserializeObject<AllBrandsList>(content);

            List<string> brands = new List<string>();
            int i = 0;
            foreach (var item in output.brands)
            {
                brands.Add(output.brands[i].brand);
                i++;
            }

            foreach (string brand in brands)
            {
                Console.WriteLine(brand);
            }
        }


    }
}