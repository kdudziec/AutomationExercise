using System;
using TechTalk.SpecFlow;
using TestCases.PageObjects;

namespace TestCases.StepDefinitions
{
    
    [Binding]
    public class TC5_RegisterUserWithExistingEmailStepDefinitions
    {
        LoginSignupPage loginSignupPage;

        public TC5_RegisterUserWithExistingEmailStepDefinitions()
        {
            loginSignupPage = new LoginSignupPage();
        }
        [When(@"Enter name and already registered email address")]
        public void WhenEnterNameAndAlreadyRegisteredEmailAddress()
        {
            loginSignupPage.EnterNameAndAlreadyRegisteredEmailAddress();
        }

        [Then(@"Verify error \*Email Address already exist!\* is visible")]
        public void ThenVerifyErrorEmailAddressAlreadyExistIsVisible()
        {
            loginSignupPage.VerifyErrorEmailAddressAlreadyExistIsVisible();
        }

    }
}
