using System;
using TechTalk.SpecFlow;
using TestCases.PageObjects;

namespace TestCases.StepDefinitions
{
    [Binding]
    public class TC7_VerifyTestCasesPageStepDefinitions
    {
        HomePage homePage;
        TestCasesPage testCasesPage;

        public TC7_VerifyTestCasesPageStepDefinitions()
        {
            homePage = new HomePage();
            testCasesPage = new TestCasesPage();
        }

        [When(@"Click on \*Test Cases\* button")]
        public void WhenClickOnTestCasesButton()
        {
            homePage.ClickOnTestCasesButton();
        }

        [Then(@"Verify user is navigated to test cases page successfully")]
        public void ThenVerifyUserIsNavigatedToTestCasesPageSuccessfully()
        {
            testCasesPage.VerifyUserIsNavigatedToTestCasesPageSuccessfully();
        }

    }
}
