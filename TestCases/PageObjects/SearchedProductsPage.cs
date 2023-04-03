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
    public class SearchedProductsPage
    {
        IWebDriver driver;
        
        IWebElement searchedProductsHeader => driver.FindElement(By.XPath("//h2[normalize-space()='Searched Products']"));
        IList<IWebElement> searchedProductsContainers => driver.FindElements(By.XPath("//div[@class='features_items']/div[@class='col-sm-4']"));
        public SearchedProductsPage() 
        {
            this.driver = Hook.driver;
        }

        public void VerifySEARCHEDPRODUCTSIsVisible()
        {
            Assert.True(searchedProductsHeader.Displayed);
        }

        public void VerifyAllTheProductsRelatedToSearchAreVisible()
        {
            foreach(var product in searchedProductsContainers) 
            {
                Assert.True(product.Displayed);
            }
        }
    }
}
