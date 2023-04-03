using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCases.Hooks;

namespace TestCases.PageObjects
{
    public class TestCasesPage
    {
        IWebDriver driver;
        public string pageTitle = "Automation Practice Website for UI Testing - Test Cases";

        public TestCasesPage()
        {
            this.driver = Hook.driver;
        }

        public void VerifyUserIsNavigatedToTestCasesPageSuccessfully()
        {
            Assert.AreEqual(driver.Title, pageTitle);
        }
    }
}
