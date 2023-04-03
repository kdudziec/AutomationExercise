using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using TestCases.Hooks;

namespace TestCases
{
    public class Utilities
    {
        IWebDriver driver;
        public string firstName = "Chuck";
        public string lastName = "Norris";
        public string signupEmail = "chucknorris@example.com";
        public string existingEmail = "chucknorris@exampleExisting.com";
        public string incorrectEmail = "chucknorris@exampleIncorrect.com";
        public string correctPassword = "chuck1234";
        public string incorrectPassword = "chuckIncorrect1234";
        public string dayOfBirth = "10";
        public string monthOfBirth = "3";
        public string yearOfBirth = "1940";
        public string company = "Chucky Films";
        public string address1 = "56 Beverly Hills";
        public string address2 = "PO 456";
        public string country = "United States";
        public string state = "California";
        public string city = "Los Angeles";
        public string zipcode = "44-675";
        public string mobileNumber = "01798675699";



        public Utilities()
        {
            this.driver = Hook.driver;
        }

        public void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);

        }

    }
}
