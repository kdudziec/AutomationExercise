using APITesting.DataModels;
using System;
using TechTalk.SpecFlow;

namespace APITesting.StepDefinitions
{
    [Binding]
    public class TC9_DELETEToVerifyLoginStepDefinitions
    {
        [When(@"DELETE")]
        public void WhenDELETE()
        {
            APIWorkshop.CreateDeleteRequest();
            APIWorkshop.GetOutput<Login>();
        }
    }
}
