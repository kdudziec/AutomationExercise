using System;
using TechTalk.SpecFlow;
using TestCases.PageObjects;

namespace TestCases.StepDefinitions
{
    [Binding]
    public class TC4_LogoutUserStepDefinitions
    {
        LoginSignupPage loginSignupPage;
        HomePage homePage;

        public TC4_LogoutUserStepDefinitions()
        {
            loginSignupPage = new LoginSignupPage();
            homePage = new HomePage();
        }

        [When(@"Enter correct existing email address and password")]
        public void WhenEnterCorrectExistingEmailAddressAndPassword()
        {
            loginSignupPage.EnterCorrectExistingEmailAddressAndPassword();
        }

        [When(@"Click \*Logout\* button")]
        public void WhenClickLogoutButton()
        {
            homePage.ClickLogoutButton();
        }

        [Then(@"Verify that user is navigated to login page")]
        public void ThenVerifyThatUserIsNavigatedToLoginPage()
        {
            loginSignupPage.VerifyThatUserIsNavigatedToLoginPage();
        }

    }
}
