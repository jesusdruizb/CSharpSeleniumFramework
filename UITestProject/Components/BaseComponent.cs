using System;
using OpenQA.Selenium;
using UITestProject.Tests.Constants;

namespace UITestProject.Components
{
    public class BaseComponent
    {
        protected IWebDriver _webDriver { get; }
        protected By byLocator { get;}
        
        public BaseComponent(IWebDriver webDriver, By locator)
        {
            this._webDriver = webDriver;
            this.byLocator = locator;
            /*
            switch (byType)
            {
                case ByType.Name:
                    this.byLocator = By.Name(locator);
                    break;
                case ByType.TagName:
                    this.byLocator = By.TagName(locator);
                    break;
                case ByType.Id:
                    this.byLocator = By.Id(locator);
                    break;
                case ByType.ClassName:
                    this.byLocator = By.ClassName(locator);
                    break;
                case ByType.Xpath:
                    this.byLocator = By.XPath(locator);
                    break;
                case ByType.CssSelector:
                    this.byLocator = By.CssSelector(locator);
                    break;
                case ByType.LinkText:
                    this.byLocator = By.LinkText(locator);
                    break;
                case ByType.PartialLinkText:
                    this.byLocator = By.PartialLinkText(locator);
                    break;
                default:
                    Console.WriteLine("Unknown Locator Type");
                    break;
            }*/

        }

        protected BaseComponent()
        {
        }
        

    }
}