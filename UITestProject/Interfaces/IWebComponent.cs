using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UITestProject.Interfaces
{
    public interface IWebComponent
    {
        bool IsComponentVisible();

        bool IsComponentVisibleAfterWait(int seconds, WebDriverWait wait);

        IWebElement WebComponent(By byLocator);
    }
}