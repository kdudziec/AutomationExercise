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
    public class ContactUsPage
    {
        IWebDriver driver;
        Utilities utilities;
        private string subject = "New movie";
        private string message = "I'm ready for the new role";

        IWebElement getInTouchHeader => driver.FindElement(By.XPath("//h2[normalize-space()='Get In Touch']"));
        IWebElement nameField => driver.FindElement(By.Name("name"));
        IWebElement emailField => driver.FindElement(By.Name("email"));
        IWebElement subjectField => driver.FindElement(By.Name("subject"));
        IWebElement messageField => driver.FindElement(By.Id("message"));
        IWebElement chooseFileButton => driver.FindElement(By.Name("upload_file"));
        IWebElement submitButton => driver.FindElement(By.Name("submit"));
        IWebElement successfullSubmissionMessageHeader => driver.FindElement(By.XPath("//div[@class='status alert alert-success']"));
        IWebElement homeButton => driver.FindElement(By.XPath("//span[normalize-space()='Home']"));


        public ContactUsPage() 
        {
            this.driver = Hook.driver;
            utilities = new Utilities();    
        }

        public void VerifyGETINTOUCHIsVisible()
        {
            Assert.True(getInTouchHeader.Displayed);
        }

        public void EnterNameEmailSubjectAndMessage()
        {
            nameField.SendKeys(utilities.firstName + " " + utilities.lastName);
            emailField.SendKeys(utilities.existingEmail);
            subjectField.SendKeys(subject);
            messageField.SendKeys(message);   
        }

        public void UploadFile()
        {
            string file = @"C:\Users\Dudi\C-Sharp Selenium\AutomationExercise\TestCases\dummyFile.png";
            chooseFileButton.SendKeys(file);

        }

        public void ClickSubmitButton()
        {
            submitButton.Click();
        }

        public void ClickOKButton()
        {
            IAlert pressOkToProceedAlert = driver.SwitchTo().Alert();
            pressOkToProceedAlert.Accept();
        }

        public void VerifySuccessMessageSuccessYourDetailsHaveBeenSubmittedSuccessfully_IsVisible()
        {
            Assert.True(successfullSubmissionMessageHeader.Displayed);
        }

        public void ClickHomeButton()
        {
            homeButton.Click();
        }
    }
}
