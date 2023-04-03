using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestCases.PageObjects;

namespace TestCases.StepDefinitions
{
    [Binding]
    public class TC6_ContactUsFormStepDefinitions
    {
        HomePage homePage;
        ContactUsPage contactUsPage;

        public TC6_ContactUsFormStepDefinitions() 
        { 
            homePage = new HomePage();  
            contactUsPage = new ContactUsPage();
        }

        [When(@"Click on \*Contact Us\* button")]
        public void WhenClickOnContactUsButton()
        {
            homePage.ClickOnContactUsButton();
        }

        [Then(@"Verify \*GET IN TOUCH\* is visible")]
        public void ThenVerifyGETINTOUCHIsVisible()
        {
            contactUsPage.VerifyGETINTOUCHIsVisible();
        }

        [When(@"Enter name, email, subject and message")]
        public void WhenEnterNameEmailSubjectAndMessage()
        {
            contactUsPage.EnterNameEmailSubjectAndMessage();
        }

        [When(@"Upload file")]
        public void WhenUploadFile()
        {
            contactUsPage.UploadFile();
        }

        [When(@"Click \*Submit\* button")]
        public void WhenClickSubmitButton()
        {
            contactUsPage.ClickSubmitButton();
        }

        [When(@"Click OK button")]
        public void WhenClickOKButton()
        {
            contactUsPage.ClickOKButton();
        }

        [Then(@"Verify success message \*Success! Your details have been submitted successfully\.\* is visible")]
        public void ThenVerifySuccessMessageSuccessYourDetailsHaveBeenSubmittedSuccessfully_IsVisible()
        {
            contactUsPage.VerifySuccessMessageSuccessYourDetailsHaveBeenSubmittedSuccessfully_IsVisible();
        }


        [When(@"Click \*Home\* button")]
        public void WhenClickHomeButton()
        {
            contactUsPage.ClickHomeButton();
        }

        [Then(@"Verify that landed to home page successfully")]
        public void ThenVerifyThatLandedToHomePageSuccessfully()
        {
            homePage.VerifyPageTitle();
        }








    }
}
