using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UITestProject.Interfaces;

namespace UITestProject.Components
{
    public class BaseComponent: IWebComponent
    {
        protected IWebDriver webDriver { get; }
        protected By byLocator { get;}

        protected WebDriverWait explicitWait;
        
        public BaseComponent(IWebDriver webDriver, By locator, WebDriverWait explicitWait)
        {
            this.webDriver = webDriver;
            this.byLocator = locator;
            this.explicitWait = explicitWait;
        }

        public BaseComponent()
        {
        }
        
        public bool IsComponentVisible()
        {
           return webDriver.FindElement(byLocator).Displayed;
        }

        public virtual bool IsComponentVisibleAfterWait(int seconds, WebDriverWait wait)
        {
            //explicitWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds));
            return explicitWait.Until(ExpectedConditions.ElementIsVisible(byLocator)) != null;
        }
        
        public IWebElement WebComponent(By byLocator)
        {
            IWebElement element = null;
            try
            {
                element = webDriver.FindElement(byLocator);
            }
            catch (ElementNotVisibleException)
            {
                element = explicitWait.Until(ExpectedConditions.ElementIsVisible(byLocator));
            }
            return element;
        }
    }
}