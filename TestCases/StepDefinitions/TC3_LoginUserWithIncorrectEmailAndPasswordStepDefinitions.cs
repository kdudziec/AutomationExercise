using System;
using TechTalk.SpecFlow;
using TestCases.PageObjects;

namespace TestCases.StepDefinitions
{
    [Binding]
    public class TC3_LoginUserWithIncorrectEmailAndPasswordStepDefinitions
    {
        LoginSignupPage loginSignupPage;

        public TC3_LoginUserWithIncorrectEmailAndPasswordStepDefinitions()
        {
            loginSignupPage = new LoginSignupPage();
        }

        [When(@"Enter incorrect email address and password")]
        public void WhenEnterIncorrectEmailAddressAndPassword()
        {
            loginSignupPage.EnterIncorrectEmailAddressAndPassword();
        }

        [Then(@"Verify error \*Your email or password is incorrect!\* is visible")]
        public void ThenVerifyErrorYourEmailOrPasswordIsIncorrectIsVisible()
        {
            loginSignupPage.VerifyError_YourEmailOrPasswordIsIncorrect_IsVisible();
        }

    }
}
