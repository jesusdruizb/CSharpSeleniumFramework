using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UITestProject.Components.Saucedemo
{
    public class Button:BaseComponent
    {
        public Button(){}
        
        public Button(IWebDriver webDriver, By locator, WebDriverWait explicitWait):base( webDriver, locator, explicitWait)
        {
        }

        public void Click()
        {
            webDriver.FindElement(byLocator).Click();
        }
    }
}