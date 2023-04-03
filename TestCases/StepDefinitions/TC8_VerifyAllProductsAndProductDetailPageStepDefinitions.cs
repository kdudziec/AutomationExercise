using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestCases.Hooks;
using TestCases.PageObjects;

namespace TestCases.StepDefinitions
{
    [Binding]
    public class TC8_VerifyAllProductsAndProductDetailPageStepDefinitions
    {
        HomePage homePage;
        ProductsPage productsPage;
        ProductDetailPage productDetailPage;
        

        public TC8_VerifyAllProductsAndProductDetailPageStepDefinitions() 
        {
            homePage = new HomePage();  
            productsPage = new ProductsPage();
            productDetailPage = new ProductDetailPage();
        }

        [When(@"Click on \*Products\* button")]
        public void WhenClickOnProductsButton()
        {
            homePage.ClickOnProductsButton();
        }

        [Then(@"Verify user is navigated to ALL PRODUCTS page successfully")]
        public void ThenVerifyUserIsNavigatedToALLPRODUCTSPageSuccessfully()
        {
            productsPage.VerifyUserIsNavigatedToALLPRODUCTSPageSuccessfully();
        }

        [Then(@"The products list is visible")]
        public void ThenTheProductsListIsVisible()
        {
            productsPage.TheProductsListIsVisible();
        }

        [When(@"Click on \*View Product\* of first product")]
        public void WhenClickOnViewProductOfFirstProduct()
        {
            productsPage.ClickOnViewProductOfFirstProduct();
        }

        [Then(@"User is landed to product detail page")]
        public void ThenUserIsLandedToProductDetailPage()
        {
            productDetailPage.UserIsLandedToProductDetailPage();
        }

        [Then(@"Verify that detail detail is visible: product name, category, price, availability, condition, brand")]
        public void ThenVerifyThatDetailDetailIsVisibleProductNameCategoryPriceAvailabilityConditionBrand()
        {
            productDetailPage.VerifyThatDetailDetailIsVisibleProductNameCategoryPriceAvailabilityConditionBrand();
        }

    }
}
