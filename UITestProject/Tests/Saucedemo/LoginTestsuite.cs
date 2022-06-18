using System;
using NUnit.Framework;
using OpenQA.Selenium;
using UITestProject.Tests.Pages.Saucedemo;

namespace UITestProject.Tests.Saucedemo
{
    public class LoginTestsuite:BaseTestSuite
    {
        [Test]
        public void InitialTest()
        {
            LoginPage loginPage = new LoginPage(WebDriver);
            loginPage.LoadPage();
            //IWebElement loginInput = WebDriver.FindElement(By.CssSelector("[data-test='username']"));
            //IWebElement passwordInput = WebDriver.FindElement(By.CssSelector("[data-test='password']"));
            //IWebElement loginButton = WebDriver.FindElement(By.CssSelector("[data-test='login-button']"));
            loginPage.usernameInput.Clear();
            loginPage.usernameInput.Type("standard_user");
            loginPage.passwordInput.Clear();
            loginPage.passwordInput.Type("secret_sauce");
            loginPage.loginButton.Click();
            Console.Read();
        }
    }
}