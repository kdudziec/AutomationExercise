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
    public class AccountDeletedPage
    {
        IWebDriver driver;
        IWebElement accountDeletedHeader => driver.FindElement(By.XPath("//b[normalize-space()='Account Deleted!']"));
        IWebElement continueButton => driver.FindElement(By.LinkText("Continue"));
        public AccountDeletedPage()
        {
            this.driver = Hook.driver;
        }
        public void Verify_AccountDeleted_IsVisible()
        {
            Assert.True(accountDeletedHeader.Displayed);
        }

        internal void ClickContinueButton()
        {
            continueButton.Click();
        }
    }
}
