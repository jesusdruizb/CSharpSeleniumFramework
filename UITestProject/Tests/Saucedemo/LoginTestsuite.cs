using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace UITestProject.Tests.Saucedemo
{
    public class LoginTestsuite:BaseTestSuite
    {
        [Test]
        public void InitialTest()
        {
            WebDriver.Navigate().GoToUrl("https://www.saucedemo.com");
            IWebElement loginInput = WebDriver.FindElement(By.CssSelector("[data-test='username']"));
            IWebElement passwordInput = WebDriver.FindElement(By.CssSelector("[data-test='password']"));
            IWebElement loginButton = WebDriver.FindElement(By.CssSelector("[data-test='login-button']"));
            loginInput.Clear();
            loginInput.SendKeys("standard_user");
            passwordInput.Clear();
            passwordInput.SendKeys("secret_sauce");
            loginButton.Click();
        }
    }
}