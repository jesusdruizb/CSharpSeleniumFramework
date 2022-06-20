using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UITestProject.Components.Saucedemo
{
    public class Input: BaseComponent
    {
        public Input(IWebDriver webDriver, By locator, WebDriverWait explicitWait):base( webDriver,  locator, explicitWait) {}

        public Input() {}

        public void Type(string keyword)
        {
            webDriver.FindElement(byLocator).SendKeys(keyword);
        }
        
        public void Clear()
        {
            webDriver.FindElement(byLocator).Clear();
        }
    }
}