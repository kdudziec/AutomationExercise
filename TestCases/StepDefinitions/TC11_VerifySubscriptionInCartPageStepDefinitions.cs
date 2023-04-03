using System;
using TechTalk.SpecFlow;
using TestCases.PageObjects;

namespace TestCases.StepDefinitions
{
    [Binding]
    public class TC11_VerifySubscriptionInCartPageStepDefinitions
    {
        HomePage homePage;
        CartPage cartPage;

        public TC11_VerifySubscriptionInCartPageStepDefinitions()
        {
            homePage = new HomePage();
            cartPage = new CartPage();
        }

        [When(@"Click \*Cart\* button")]
        public void WhenClickCartButton()
        {
            homePage.ClickCartButton();
        }

        [When(@"Scroll down to footer in Cart Page")]
        public void WhenScrollDownToFooterInCartPage()
        {
            cartPage.ScrollDownToFooter();
        }


        [Then(@"Verify text \*SUBSCRIPTION\* in Cart Page")]
        public void ThenVerifyTextSUBSCRIPTIONInCartPage()
        {
            cartPage.VerifyTextSUBSCRIPTION();
        }

        [When(@"Enter email address in input and click arrow button in Cart Page")]
        public void WhenEnterEmailAddressInInputAndClickArrowButtonInCartPage()
        {
            cartPage.EnterEmailAddressInInputAndClickArrowButton();
        }

        [Then(@"Verify success message \*You have been successfully subscribed!\* is visible Cart Page")]
        public void ThenVerifySuccessMessageYouHaveBeenSuccessfullySubscribedIsVisibleCartPage()
        {
            cartPage.VerifySuccessMessageYouHaveBeenSuccessfullySubscribedIsVisible();
        }



    }
}
