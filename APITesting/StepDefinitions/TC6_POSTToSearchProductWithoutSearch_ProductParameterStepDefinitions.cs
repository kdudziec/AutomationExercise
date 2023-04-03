using APITesting.DataModels;
using System;
using TechTalk.SpecFlow;

namespace APITesting.StepDefinitions
{
    [Binding]
    public class TC6_POSTToSearchProductWithoutSearch_ProductParameterStepDefinitions
    {
        [When(@"POST empty to Search Product")]
        public void WhenPOSTEmptyToSearchProduct()
        {
            APIWorkshop.CreateEmptyPostRequest();
            APIWorkshop.GetOutput<SearchedProducts>();
        }
    }
}
