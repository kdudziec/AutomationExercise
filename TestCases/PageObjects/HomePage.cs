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
    public class HomePage
    {
        Utilities utilities = new Utilities();
        public string pageTitle = "Automation Exercise";

        IWebDriver driver;
        IWebElement productsLink => driver.FindElement(By.XPath("//a[@href='/products']"));
        IWebElement cartLink => driver.FindElement(By.PartialLinkText("Cart"));
        IWebElement loginSignupButton => driver.FindElement(By.PartialLinkText("Signup / Log"));
        IWebElement testCasesLink => driver.FindElement(By.PartialLinkText("Test Cas"));
        IWebElement contactUsLink => driver.FindElement(By.PartialLinkText("Contact"));
        IWebElement loggedUserName => driver.FindElement(By.XPath("//b[normalize-space()='" + utilities.firstName + " " + utilities.lastName + "']"));
        IWebElement deleteAccountLink => driver.FindElement(By.PartialLinkText("Delete Accou"));
        IWebElement logoutLink => driver.FindElement(By.PartialLinkText("Logo"));
        IWebElement footer => driver.FindElement(By.Id("footer"));
        IWebElement subscriptionHeader => driver.FindElement(By.XPath("//h2[normalize-space()='Subscription']"));
        IWebElement subscriptionEmailField => driver.FindElement(By.Id("susbscribe_email"));
        IWebElement subscriptionButton => driver.FindElement(By.CssSelector(".fa.fa-arrow-circle-o-right"));
        By successfulSubscriptionMessage => By.XPath("//*[contains(text(), 'You have been successfully subscribed!')]");

        public HomePage()
        {
            this.driver = Hook.driver;
        }

        public void NavigateToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void VerifyPageTitle()
        {
            Assert.AreEqual(driver.Title, pageTitle);
        }

        public void ClickOnLoginSignupButton()
        {
            loginSignupButton.Click();
        }

        public void VerifyThatLoggedInAsUsernameIsVisible()
        {
            Assert.True(loggedUserName.Displayed);
        }

        public void ClickDeleteAccountButton()
        {
            deleteAccountLink.Click();
        }

        public void ClickLogoutButton()
        {
            logoutLink.Click();
        }

        public void ClickOnTestCasesButton()
        {
            testCasesLink.Click();
        }

        public void ClickOnContactUsButton()
        {
            contactUsLink.Click();
        }

        public void ClickOnProductsButton()
        {
            productsLink.Click();
        }

        public void ScrollDownToFooter()
        {
            utilities.ScrollToElement(footer);
        }

        public void VerifyTextSUBSCRIPTION()
        {
            Assert.True(subscriptionHeader.Displayed);
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

        public void ClickCartButton()
        {
            cartLink.Click();
        }
    }
}
