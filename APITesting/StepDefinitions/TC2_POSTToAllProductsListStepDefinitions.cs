using APITesting.DataModels;
using Gherkin.Ast;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace APITesting.StepDefinitions
{
    [Binding]
    public class TC2_POSTToAllProductsListStepDefinitions
    {
        public dynamic output;

        [When(@"Post empty to All Products List")]
        public void WhenPostEmptyToAllProductsList()
        {
            APIWorkshop.CreateEmptyPostRequest();
            APIWorkshop.GetOutput<AllProductsList>();
        }

        [Then(@"Response Message is ""([^""]*)""")]
        public void ThenResponseMessageIs(string message)
        {
            output = APIWorkshop.output;
            Assert.That(output.message, Is.EqualTo(message));
        }


    }
}
