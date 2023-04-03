using APITesting.DataModels;
using Gherkin.Ast;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Newtonsoft.Json;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace APITesting.StepDefinitions
{
    [Binding]
    public class TC3_GetAllBrandssListStepDefinitions
    {
        public dynamic output;


        [When(@"Get All Brands List")]
        public void WhenGetAllBrandsList()
        {
            APIWorkshop.CreateGetRequest();
            APIWorkshop.GetOutput<AllBrandsList>();
            output = APIWorkshop.output;
        }

        [Then(@"Response JSON is All Brand list")]
        public void ThenResponseJSONIsAllBrandList()
        {
            output = APIWorkshop.output;
            List<string> brands = new List<string>();
            int i = 0;
            foreach (var item in output.brands)
            {
                brands.Add(output.brands[i].brand);
                i++;
            }

            //Print all the brands names on the Console
            foreach (string brand in brands)
            {
                Console.WriteLine(brand);
            }
        }
    }
}
