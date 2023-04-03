using APITesting.DataModels;
using System;
using TechTalk.SpecFlow;

namespace APITesting.StepDefinitions
{
    [Binding]
    public class TC4_PUTToAllBrandsListStepDefinitions
    {
        [When(@"Put empty to All Brands List")]
        public void WhenPutEmptyToAllBrandsList()
        {
            APIWorkshop.CreateEmptyPutRequest();
            APIWorkshop.GetOutput<AllBrandsList>();
        }

    }
}
