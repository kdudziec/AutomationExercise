using System;
using TechTalk.SpecFlow;
using TestCases.PageObjects;

namespace TestCases.StepDefinitions
{
    [Binding]
    public class TC9_SearchProductStepDefinitions
    {
        ProductsPage productsPage;
        SearchedProductsPage searchedProductsPage;

        public TC9_SearchProductStepDefinitions() 
        {
            productsPage = new ProductsPage();  
            searchedProductsPage = new SearchedProductsPage();
        }   
        [When(@"Enter product name in search input and click search button")]
        public void WhenEnterProductNameInSearchInputAndClickSearchButton()
        {
            productsPage.EnterProductNameInSearchInputAndClickSearchButton();
        }

        [Then(@"Verify \*SEARCHED PRODUCTS\* is visible")]
        public void ThenVerifySEARCHEDPRODUCTSIsVisible()
        {
            searchedProductsPage.VerifySEARCHEDPRODUCTSIsVisible();
        }

        [Then(@"Verify all the products related to search are visible")]
        public void ThenVerifyAllTheProductsRelatedToSearchAreVisible()
        {
            searchedProductsPage.VerifyAllTheProductsRelatedToSearchAreVisible();
        }


    }
}
