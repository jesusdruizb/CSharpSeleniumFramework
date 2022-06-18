using OpenQA.Selenium;

namespace UITestProject.Components.Saucedemo
{
    public class Input: BaseComponent
    {
        private IWebElement _webElement;
        public Input(IWebDriver webDriver, By locator):base( webDriver,  locator)
        {
            
        }

        public Input()
        {
        }

        public void Type(string keyword)
        {
            _webDriver.FindElement(byLocator).SendKeys(keyword);
        }
        
        public void Clear()
        {
            _webDriver.FindElement(byLocator).Clear();
        }
    }
}