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
    public class ProductsPage
    {
        IWebDriver driver;
        string searchedProduct = "dress";


        IWebElement searchField => driver.FindElement(By.Id("search_product"));
        IWebElement searchButton => driver.FindElement(By.Id("submit_search"));
        IWebElement allProductsHeader => driver.FindElement(By.XPath("//h2[normalize-space()='All Products']"));
        IWebElement firstProductClass => driver.FindElement(By.XPath("(//div[@class='col-sm-4'])[2]"));
        IWebElement viewFirstProductLink => driver.FindElement(By.XPath("(//a[contains(text(),'View Product')])[1]"));
        public ProductsPage() 
        {
            this.driver = Hook.driver;
        }

        public void VerifyUserIsNavigatedToALLPRODUCTSPageSuccessfully()
        {
            Assert.True(allProductsHeader.Displayed);
        }

        public void TheProductsListIsVisible()
        {
            Assert.True(firstProductClass.Displayed);
        }

        public void ClickOnViewProductOfFirstProduct()
        {
            viewFirstProductLink.Click();
        }

        public void EnterProductNameInSearchInputAndClickSearchButton()
        {
            searchField.SendKeys(searchedProduct);
            searchButton.Click();
        }

    }
}
