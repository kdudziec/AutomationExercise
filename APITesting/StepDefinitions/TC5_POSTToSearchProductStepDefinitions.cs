using APITesting.DataModels;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace APITesting.StepDefinitions
{
    [Binding]
    public class TC5_POSTToSearchProductStepDefinitions
    {
        public dynamic output;

        [When(@"POST ""([^""]*)"" ""([^""]*)""")]
        public void WhenPOST(string key1, string value1)
        {
            APIWorkshop.CreatePostRequest(key1, value1);
            APIWorkshop.GetOutput<SearchedProducts>();
        }



        [When(@"POST ""([^""]*)""")]
        public void WhenPOST(string parameters)
        {
            string[] pair = parameters.Split(',');
            foreach (string item in pair)
            {
                string[] keyValue = item.Split(':');
                string key = keyValue[0];
                string value = keyValue[1];
                APIWorkshop.CreatePostRequest(key, value);
            }
            APIWorkshop.GetOutput<SearchedProducts>();
        }

        [Then(@"Response JSON is Searched products list")]
        public void ThenResponseJSONisSearchedProductsList()
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
