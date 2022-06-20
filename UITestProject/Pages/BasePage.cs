using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UITestProject.Interfaces;

namespace UITestProject.Tests.Pages
{
    public class BasePage: IWebPage
    {
        //Attributes
        IWebDriver _WebDriver;

        protected WebDriverWait _Wait;
        //Methods

        public BasePage(IWebDriver webDriver, int waitSeconds = 10)
        {
            this._WebDriver = webDriver;
            this._Wait = new WebDriverWait(_WebDriver, TimeSpan.FromSeconds(waitSeconds));
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
        public IWebElement waitForElement(By webElement, int seconds)
        {
            return _Wait.Until(e => e.FindElement(webElement));
        }
    }
}