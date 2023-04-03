using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCases.Hooks;

namespace TestCases.PageObjects
{
    public class CartPage
    {
        Utilities utilities;
        IWebDriver driver;

        IWebElement subscriptionHeader => driver.FindElement(By.XPath("//h2[normalize-space()='Subscription']"));
        IWebElement footer => driver.FindElement(By.Id("footer"));
        IWebElement subscriptionEmailField => driver.FindElement(By.Id("susbscribe_email"));
        IWebElement subscriptionButton => driver.FindElement(By.CssSelector(".fa.fa-arrow-circle-o-right"));
        By successfulSubscriptionMessage => By.XPath("//*[contains(text(), 'You have been successfully subscribed!')]");


        public CartPage()
        {
            utilities = new Utilities();
            this.driver = Hook.driver;
        }

        public void VerifyTextSUBSCRIPTION()
        {
            Assert.True(subscriptionHeader.Displayed);
        }

        public void ScrollDownToFooter()
        {
            utilities.ScrollToElement(footer); ;
        }

        public void EnterEmailAddressInInputAndClickArrowButton()
        {
            subscriptionEmailField.SendKeys(utilities.existingEmail);
            subscriptionButton.Click();
        }

        public void VerifySuccessMessageYouHaveBeenSuccessfullySubscribedIsVisible()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            Assert.True(wait.Until(ExpectedConditions.ElementIsVisible(successfulSubscriptionMessage)).Displayed);
        }
    }
}
