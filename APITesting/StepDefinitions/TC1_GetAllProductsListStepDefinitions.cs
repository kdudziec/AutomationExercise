using APITesting.DataModels;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Runtime.ConstrainedExecution;
using TechTalk.SpecFlow;
using static APITesting.DataModels.AllProductsList;

namespace APITesting.StepDefinitions
{
    [Binding]
    public class TC1_GetAllProductsListStepDefinitions
    {
        public dynamic output;


        [Given(@"API URL is ""([^""]*)""")]
        public void GivenAPIURLIs(string url)
        {
            APIWorkshop.SetUrl(url);
        }


        [When(@"Get All Products List")]
        public void WhenGetAllProductsList()
        {
            APIWorkshop.CreateGetRequest();
            APIWorkshop.GetOutput<AllProductsList>();
            output = APIWorkshop.output;
        }

        [Then(@"Response Code is (.*)")]
        public void ThenResponseCodeIs(int code)
        {
            output = APIWorkshop.output;
            Assert.That(output.responseCode, Is.EqualTo(code));
        }

        [Then(@"Response JSON is All products list")]
        public void ThenResponseJSONIsAllProductsList()
        {
            output = APIWorkshop.output;
            List<string> productNames = new List<string>();
            int i = 0;
            foreach (var product in output.products)
            {
                productNames.Add(output.products[i].name);
                i++;
            }

            //Print all the products names on the Console
            foreach (var productName in productNames)
            {
                Console.WriteLine(productName);
            }
        }
    }
}
