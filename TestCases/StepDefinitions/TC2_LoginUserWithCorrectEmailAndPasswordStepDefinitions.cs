using System;
using TechTalk.SpecFlow;
using TestCases.PageObjects;

namespace TestCases.StepDefinitions
{
    [Binding]
    public class TC2_LoginUserWithCorrectEmailAndPasswordStepDefinitions
    {
        LoginSignupPage loginSignupPage;

        public TC2_LoginUserWithCorrectEmailAndPasswordStepDefinitions()
        {
            loginSignupPage = new LoginSignupPage();    
        }

        [Then(@"Verify \*Login to your account\* is visible")]
        public void ThenVerifyLoginToYourAccountIsVisible()
        {
            loginSignupPage.VerifyLoginToYourAccountIsVisible();
        }

        [When(@"Enter correct email address and password")]
        public void WhenEnterCorrectEmailAddressAndPassword()
        {
            loginSignupPage.EnterCorrectEmailAddressAndPassword();
        }

        [When(@"Click \*login\* button")]
        public void WhenClickLoginButton()
        {
            loginSignupPage.WhenClickLoginButton();
        }

    }
}
