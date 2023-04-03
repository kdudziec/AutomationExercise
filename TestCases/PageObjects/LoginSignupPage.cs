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
    public class LoginSignupPage
    {
        Utilities utilities = new Utilities();
        IWebDriver driver;
        public string pageTitle = "Automation Exercise - Signup / Login";

        IWebElement loginToYourAccountHeader => driver.FindElement(By.XPath("//h2[normalize-space()='Login to your account']"));
        IWebElement loginEmailAddressField => driver.FindElement(By.XPath("//input[@data-qa='login-email']"));
        IWebElement loginPasswordField => driver.FindElement(By.Name("password"));
        IWebElement loginButton => driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
        IWebElement loginErrorMessage => driver.FindElement(By.XPath("//p[normalize-space()='Your email or password is incorrect!']"));

        IWebElement newUserSignupHeader => driver.FindElement(By.XPath("//h2[normalize-space()='New User Signup!']"));
        IWebElement signupNameField => driver.FindElement(By.Name("name"));
        IWebElement signupEmailAddressField => driver.FindElement(By.XPath("//input[@data-qa='signup-email']"));
        IWebElement signupButton => driver.FindElement(By.XPath("//button[normalize-space()='Signup']"));
        IWebElement existingUserMessage => driver.FindElement(By.XPath("//p[normalize-space()='Email Address already exist!']"));

        public LoginSignupPage()
        {
            this.driver = Hook.driver;
        }

        public void VerifyNewUserSignupVisible()
        {
            Assert.True(newUserSignupHeader.Displayed);
        }

        public void EnterNameAndEmailAddress()
        {
            signupNameField.SendKeys(utilities.firstName + " " + utilities.lastName);
            signupEmailAddressField.SendKeys(utilities.signupEmail);  
        }

        public void ClickOnSignupButton()
        {
            signupButton.Click();
        }

        public void VerifyLoginToYourAccountIsVisible()
        {
            Assert.True(loginToYourAccountHeader.Displayed);
        }

        public void EnterCorrectEmailAddressAndPassword()
        {
            loginEmailAddressField.SendKeys(utilities.signupEmail);
            loginPasswordField.SendKeys(utilities.correctPassword);
        }

        public void WhenClickLoginButton()
        {
            loginButton.Click();
        }

        public void EnterIncorrectEmailAddressAndPassword()
        {
            loginEmailAddressField.SendKeys(utilities.incorrectEmail);
            loginPasswordField.SendKeys(utilities.incorrectPassword);
        }

        public void VerifyError_YourEmailOrPasswordIsIncorrect_IsVisible()
        {
            Assert.True(loginErrorMessage.Displayed);
        }

        public void EnterCorrectExistingEmailAddressAndPassword()
        {
            loginEmailAddressField.SendKeys(utilities.existingEmail);
            loginPasswordField.SendKeys(utilities.correctPassword);
        }

        public void VerifyThatUserIsNavigatedToLoginPage()
        {
            Assert.AreEqual(driver.Title, pageTitle);
        }

        public void EnterNameAndAlreadyRegisteredEmailAddress()
        {
            signupNameField.SendKeys(utilities.firstName + " " + utilities.lastName);
            signupEmailAddressField.SendKeys(utilities.existingEmail);
        }

        public void VerifyErrorEmailAddressAlreadyExistIsVisible()
        {
            Assert.True(existingUserMessage.Displayed);
        }
    }
}
