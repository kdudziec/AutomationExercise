using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Principal;
using TechTalk.SpecFlow;
using TestCases.PageObjects;

namespace TestCases.StepDefinitions
{
    [Binding]
    public class TC1_RegisterUserStepDefinitions
    {
        HomePage homePage;
        LoginSignupPage loginSignupPage;
        EnterAccountInformationPage enterAccountInformationPage;
        AccountCreatedPage accountCreatedPage;
        AccountDeletedPage accountDeletedPage;

        public TC1_RegisterUserStepDefinitions()
        {
            homePage = new HomePage();
            loginSignupPage = new LoginSignupPage();
            enterAccountInformationPage = new EnterAccountInformationPage();
            accountCreatedPage = new AccountCreatedPage();
            accountDeletedPage = new AccountDeletedPage();
        }

        [Given(@"Launch browser")]
        public void GivenLaunchBrowser()
        {
            //Launching from Hook
        }

        [When(@"Navigate to url '([^']*)'")]
        public void WhenNavigateToUrl(string url)
        {
            homePage.NavigateToPage(url);
        }

        [Then(@"Verify that home page is visible successfully")]
        public void ThenVerifyThatHomePageIsVisibleSuccessfully()
        {
            homePage.VerifyPageTitle();
        }

        [When(@"Click on \*Signup / Login\* button")]
        public void WhenClickOnLoginSignupButton()
        {
            homePage.ClickOnLoginSignupButton();
        }

        [Then(@"Verify \*New User Signup!\* is visible")]
        public void ThenVerifyNewUserSignupIsVisible()
        {
            loginSignupPage.VerifyNewUserSignupVisible();  
        }

        [When(@"Enter name and email address")]
        public void WhenEnterNameAndEmailAddress()
        {
            loginSignupPage.EnterNameAndEmailAddress();
        }

        [When(@"Click \*Signup\* button")]
        public void WhenClickSignupButton()
        {
            loginSignupPage.ClickOnSignupButton();
        }

        [Then(@"Verify that \*ENTER ACCOUNT INFORMATION\* is visible")]
        public void ThenVerifyThat_EnterAccountInformation_IsVisible()
        {
            enterAccountInformationPage.Verify_EnterAccountInformationHeader_IsVisible();
        }

        [When(@"Fill details: Title, Name, Email, Password, Date of birth")]
        public void WhenFillDetails_Title_Name_Email_Password_DateOfBirth()
        {
            enterAccountInformationPage.Enter_Title_Name_Email_Password_DateOfBirth();
        }

        [When(@"Select checkbox \*Sign up for our newsletter!\*")]
        public void WhenSelectCheckboxSignUpForOurNewsletter()
        {
            enterAccountInformationPage.Tick_SignUpForOurNewsletter_CheckBox();
        }

        [When(@"Select checkbox \*Receive special offers from our partners!\*")]
        public void WhenSelectCheckboxReceiveSpecialOffersFromOurPartners()
        {
            enterAccountInformationPage.Tick_ReceiveSpecialOffersFromOurPartners_CheckBox();
        }

        [When(@"Fill details: First name, Last name, Company, Address, Address(.*), Country, State, City, Zipcode, Mobile Number")]
        public void WhenFillDetailsFirstNameLastNameCompanyAddressAddressCountryStateCityZipcodeMobileNumber(int p0)
        {
            enterAccountInformationPage.FillDetails_FirstNameLastNameCompanyAddressAddressCountryStateCityZipcodeMobileNumber();
        }

        [When(@"Click \*Create Account button\*")]
        public void WhenClick_CreateAccount_Button()
        {
            enterAccountInformationPage.Click_CreateAccount_Button();
        }


        [Then(@"Verify that \*ACCOUNT CREATED!\* is visible")]
        public void ThenVerifyThat_AccountCreated_IsVisible()
        {
            accountCreatedPage.Verify_AccountCreated_IsVisible();
        }

        [When(@"Click \*Continue\* button")]
        public void WhenClick_Continue_Button()
        {
            accountCreatedPage.Click_Continue_Button();
        }

        [Then(@"Verify that \*Logged in as username\* is visible")]
        public void ThenVerifyThatLoggedInAsUsernameIsVisible()
        {
            homePage.VerifyThatLoggedInAsUsernameIsVisible();
        }

        [When(@"Click \*Delete Account\* button")]
        public void WhenClickDeleteAccountButton()
        {
            homePage.ClickDeleteAccountButton();
        }


        [Then(@"Verify that \*ACCOUNT DELETED!\* is visible and click \*Continue\* button")]
        public void ThenVerifyThatACCOUNTDELETEDIsVisibleAndClickContinueButton()
        {
            accountDeletedPage.Verify_AccountDeleted_IsVisible();
            accountDeletedPage.ClickContinueButton();
        }









    }
}
