using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
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

        [SetUp]
        public void BrowserInit()
        {
            BuildBrowser("remote","firefox");
        }
        public void BuildBrowser(string type, string browserType)
        {
            if (type.ToLower().Equals("local"))
            {
                switch (browserType.ToLower())
                {
                    case "chrome":
                        ChromeDriverSetup();
                        break;
                    case "firefox":
                        FirefoxDriverSetup();
                        break;
                    default:
                       throw new ArgumentException("Unknown browser type, chose Chrome or Firefox");
                }
            }
            else if (type.ToLower().Equals("remote"))
            {
                RemoteDriverSetup(browserType);
            }
            else
            {
                throw new ArgumentException($"{type} of test invalid, chose local or remote");
            }
        }

        public void ChromeDriverSetup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            //new DriverManager().SetUpDriver(new ChromeConfig());
            WebDriver = new ChromeDriver();
        }
        
        public void FirefoxDriverSetup()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            WebDriver = new FirefoxDriver();
        }
        
        public void RemoteDriverSetup(string browserType)
        {
            Uri DOCKER_GRID_URI = new Uri("http://localhost:4444/wd/hub");

            switch (browserType.ToLower())
            {
                case "chrome":
                    ChromeOptions chromeOptions = new ChromeOptions{BrowserVersion= "", PlatformName  ="Linux"};
                    chromeOptions.AddArgument("--start-maximized");
                    WebDriver = new RemoteWebDriver(DOCKER_GRID_URI, chromeOptions.ToCapabilities());
                    break;
                case "firefox":
                    FirefoxOptions ffOptions = new FirefoxOptions{BrowserVersion= "", PlatformName  ="Linux"};
                    ffOptions.AddArgument("--start-maximized");
                    WebDriver = new RemoteWebDriver(DOCKER_GRID_URI, ffOptions.ToCapabilities());
                    break;
                default:
                    throw new ArgumentException("Unknown browser type, chose Chrome or Firefox");
            }
         }
        
        [TearDown]
        public void DriverTearDown()
        {
            WebDriver.Quit();
        }
    }
}