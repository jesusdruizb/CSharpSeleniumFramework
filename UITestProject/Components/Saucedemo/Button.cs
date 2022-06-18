using OpenQA.Selenium;

namespace UITestProject.Components.Saucedemo
{
    public class Button:BaseComponent
    {
        private IWebElement _webElement;
        
        public Button(){}
        
        public Button(IWebDriver webDriver, By locator):base( webDriver, locator)
        {
        }

        public void Click()
        {
            _webDriver.FindElement(byLocator).Click();
        }
    }
}