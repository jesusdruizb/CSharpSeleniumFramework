using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;


namespace UITestProject.Tests
{
    [TestFixture]
    public class BaseTestSuite
    {
        public IWebDriver WebDriver { get; set; }
        public string BrowserType { get; set; }
        
        
        public void ChromeDriverSetup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            //new DriverManager().SetUpDriver(new ChromeConfig());
            WebDriver = new ChromeDriver();
        }
        /*
        public void ReadBrowserType()
        {
            BrowserType = TestContext.Parameters.Get("browser", "");
            switch (BrowserType)
            {
                case "Chrome":
                    ChromeDriverSetup();
                    break;
                case "Firefox":
                    FirefoxDriverSetup();
                    break;
                default:
                    Console.WriteLine("Unknown browser type");
                    break;
            }
        }
        */
        [SetUp]
        public void FirefoxDriverSetup()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            WebDriver = new FirefoxDriver();
        }
        
        [TearDown]
        public void DriverTearDown()
        {
            WebDriver.Quit();
        }
    }
}