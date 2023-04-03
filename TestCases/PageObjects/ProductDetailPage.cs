using FluentAssertions;
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
    public class ProductDetailPage
    {
        IWebDriver driver;
        string pageTitle = "Automation Exercise - Product Details";
        IWebElement productNameDetail => driver.FindElement(By.XPath("//div[@class='product-information']/h2"));
        IWebElement productCategoryDetail => driver.FindElement(By.XPath("//div[@class='product-information']/p[1]"));
        IWebElement productPriceDetail => driver.FindElement(By.XPath("//div[@class='product-information']/span/span"));
        IWebElement productAvailabilityDetail => driver.FindElement(By.XPath("//div[@class='product-information']/p[2]"));
        IWebElement productConditionDetail => driver.FindElement(By.XPath("//div[@class='product-information']/p[3]"));
        IWebElement productBrandDetail => driver.FindElement(By.XPath("//div[@class='product-information']/p[4]"));



        public ProductDetailPage()
        {
            this.driver = Hook.driver;
        }

        public void UserIsLandedToProductDetailPage()
        {
            Assert.AreEqual(driver.Title, pageTitle);
        }

        public void VerifyThatDetailDetailIsVisibleProductNameCategoryPriceAvailabilityConditionBrand()
        {
            Assert.Greater(productNameDetail.Text.Length, 0);
            Assert.Greater(productCategoryDetail.Text.Replace("Category:", "").Trim().Length, 0);
            Assert.Greater(productPriceDetail.Text.Replace("Rs.", "").Trim().Length, 0);
            Assert.Greater(productAvailabilityDetail.Text.Replace("Availability:", "").Trim().Length, 0);
            Assert.Greater(productConditionDetail.Text.Replace("Condition:", "").Trim().Length, 0);
            Assert.Greater(productBrandDetail.Text.Replace("Brand:", "").Trim().Length, 0);
        }
    }
}
