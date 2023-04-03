using APITesting.DataModels;
using Newtonsoft.Json.Linq;
using System;
using TechTalk.SpecFlow;

namespace APITesting.StepDefinitions
{
    [Binding]
    public class TC7_POSTToVerifyLoginWithValidDetailsStepDefinitions
    {
        [When(@"POST ""([^""]*)"" ""([^""]*)"" and ""([^""]*)"" ""([^""]*)""")]
        public void WhenPOSTAnd(string key1, string value1, string key2, string value2)
        {
            APIWorkshop.CreatePostRequest(key1, value1, key2, value2);
            APIWorkshop.GetOutput<Login>();
        }
    }
}
