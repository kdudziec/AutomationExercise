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
    public class AccountCreatedPage
    {
        IWebDriver driver;

        IWebElement accountCreatedHeader => driver.FindElement(By.XPath("//b[normalize-space()='Account Created!']"));
        IWebElement continueButton => driver.FindElement(By.LinkText("Continue"));
        public AccountCreatedPage()
        {
            this.driver = Hook.driver;
        }

        public void Verify_AccountCreated_IsVisible()
        {
            Assert.True(accountCreatedHeader.Displayed);
        }

        internal void Click_Continue_Button()
        {
            continueButton.Click();
        }
    }
}
