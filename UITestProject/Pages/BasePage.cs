using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UITestProject.Tests.Pages
{
    public class BasePage
    {
        //Attributes
        private IWebDriver _WebDriver;
        //Methods

        public BasePage(IWebDriver webDriver)
        {
            this._WebDriver = webDriver;
        }

        public void NavigateTo(string url)
        {
            _WebDriver.Navigate().GoToUrl(url);
        }

        public IWebElement FindElementByLocator(By elementLocator)
        {
            IWebElement foundElement = null;
            try
            {
                foundElement = _WebDriver.FindElement(elementLocator);
            }
            catch (NoSuchElementException nse)
            {
                TestContext.Write(nse);
                Assert.Fail($"element {elementLocator} not found");
            }
            return foundElement;
        }
        
        public void ClickElement(By elementLocator)
        {
            FindElementByLocator(elementLocator).Click();   
        }

        public void SendKeys(By elementLocator, string keys)
        {
            FindElementByLocator(elementLocator).SendKeys(keys);   
        }
        
        public IWebElement waitForElement(IWebDriver driver, By webElement, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            return wait.Until(e => e.FindElement(webElement));
        }
    }
}