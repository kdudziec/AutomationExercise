using System;
using TechTalk.SpecFlow;
using TestCases.PageObjects;

namespace TestCases.StepDefinitions
{
    [Binding]
    public class TC10_VerifySubscriptionInHomePageStepDefinitions
    {
        HomePage homePage;

        public TC10_VerifySubscriptionInHomePageStepDefinitions()
        {
            homePage = new HomePage();  
        }


        [When(@"Scroll down to footer")]
        public void WhenScrollDownToFooter()
        {
            homePage.ScrollDownToFooter();
        }


        [Then(@"Verify text \*SUBSCRIPTION\*")]
        public void ThenVerifyTextSUBSCRIPTION()
        {
            homePage.VerifyTextSUBSCRIPTION();
        }

        [When(@"Enter email address in input and click arrow button")]
        public void WhenEnterEmailAddressInInputAndClickArrowButton()
        {
            homePage.EnterEmailAddressInInputAndClickArrowButton();
        }

        [Then(@"Verify success message \*You have been successfully subscribed!\* is visible")]
        public void ThenVerifySuccessMessageYouHaveBeenSuccessfullySubscribedIsVisible()
        {
            homePage.VerifySuccessMessageYouHaveBeenSuccessfullySubscribedIsVisible();
        }

    }
}
