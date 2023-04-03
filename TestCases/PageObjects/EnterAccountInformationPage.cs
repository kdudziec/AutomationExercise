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
    public class EnterAccountInformationPage
    {
        Utilities utilities = new Utilities();
        IWebDriver driver;
        IWebElement enterAccountInformationHeader => driver.FindElement(By.XPath("//b[normalize-space()='Enter Account Information']"));
        IWebElement titleRadioButton => driver.FindElement(By.Id("id_gender1"));
        IWebElement passwordField => driver.FindElement(By.Id("password"));
        By dayDropDown => By.Id("days");
        By monthDropDown => By.Id("months");
        By yearDropDown => By.Id("years");
        IWebElement signUpForOurNewslettetCheckBox => driver.FindElement(By.Id("newsletter"));
        IWebElement receiveSpecialOffersFromOurPartnersCheckBox => driver.FindElement(By.Id("optin"));
        IWebElement firstNameField => driver.FindElement(By.Id("first_name"));
        IWebElement lastNameField => driver.FindElement(By.Id("last_name"));
        IWebElement companyField => driver.FindElement(By.Id("company"));
        IWebElement address1Field => driver.FindElement(By.Id("address1"));
        IWebElement address2Field => driver.FindElement(By.Id("address2"));
        By countryDropDown => By.Id("country");
        IWebElement stateField => driver.FindElement(By.Id("state"));
        IWebElement cityField => driver.FindElement(By.Id("city"));
        IWebElement zipcodeField => driver.FindElement(By.Id("zipcode"));
        IWebElement mobileNumberField => driver.FindElement(By.Id("mobile_number"));
        IWebElement createAccountButton => driver.FindElement(By.XPath("//button[normalize-space()='Create Account']"));



        public EnterAccountInformationPage() 
        { 
            this.driver = Hook.driver;
        }

        public void Verify_EnterAccountInformationHeader_IsVisible()
        {
            Assert.True(enterAccountInformationHeader.Displayed);
        }

        public void Enter_Title_Name_Email_Password_DateOfBirth()
        {
            titleRadioButton.Click();
            passwordField.SendKeys(utilities.correctPassword);

            //Enter Date of Birth
            SelectElement dayDropDownSelected = new SelectElement(driver.FindElement(dayDropDown));
            dayDropDownSelected.SelectByValue(utilities.dayOfBirth);
            SelectElement monthDropDownSelected = new SelectElement(driver.FindElement(monthDropDown));
            monthDropDownSelected.SelectByValue(utilities.monthOfBirth);          
            SelectElement yearDropDownSelected = new SelectElement(driver.FindElement(yearDropDown));
            yearDropDownSelected.SelectByValue(utilities.yearOfBirth);

        }

        public void Tick_SignUpForOurNewsletter_CheckBox()
        {
            utilities.ScrollToElement(signUpForOurNewslettetCheckBox);
            signUpForOurNewslettetCheckBox.Click();
        }

        public void Tick_ReceiveSpecialOffersFromOurPartners_CheckBox()
        {
            receiveSpecialOffersFromOurPartnersCheckBox.Click();
        }

        public void FillDetails_FirstNameLastNameCompanyAddressAddressCountryStateCityZipcodeMobileNumber()
        {
            firstNameField.SendKeys(utilities.firstName);
            lastNameField.SendKeys(utilities.lastName);
            companyField.SendKeys(utilities.company);

            utilities.ScrollToElement(address1Field);

            address1Field.SendKeys(utilities.address1);
            address2Field.SendKeys(utilities.address2);

            SelectElement countryDropDownSelected = new SelectElement(driver.FindElement(countryDropDown));
            countryDropDownSelected.SelectByValue(utilities.country);

            stateField.SendKeys(utilities.state);
            cityField.SendKeys(utilities.city);
            zipcodeField.SendKeys(utilities.zipcode);
            mobileNumberField.SendKeys(utilities.mobileNumber);
        }

        public void Click_CreateAccount_Button()
        {
            createAccountButton.Click();
        }
    }
}
