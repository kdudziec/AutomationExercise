using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TechTalk.SpecFlow;

namespace TestCases.Hooks
{
    [Binding]
    public class Hook
    {
        public static IWebDriver driver;
        By checkoutNowButton => By.Id("lock");   
        [BeforeScenario]
        public void BeforeScenario()
        {
            //Install AdBlocker
            var adBlocker = new ChromeOptions();
            adBlocker.AddExtensions(@"C:\Users\Dudi\PycharmProjects\SeleniumExercises\AdBlock-—-best-ad-blocker.crx");
            driver = new ChromeDriver(adBlocker);
            driver.Manage().Window.Maximize();

            //Close the window with AdBlocker intallation when ready
            while (true)
            {                              
                try
                {
                    driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
                    break;
                }
                catch
                {
                    
                }
            }

            //Switch back to the main Window
            driver.SwitchTo().Window(driver.WindowHandles[0]);


        }



        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}