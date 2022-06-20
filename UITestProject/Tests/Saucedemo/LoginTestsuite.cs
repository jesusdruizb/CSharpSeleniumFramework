using System;
using NUnit.Framework;
using OpenQA.Selenium;
using UITestProject.Pages.Saucedemo;

namespace UITestProject.Tests.Saucedemo
{
    public class LoginTestsuite:BaseTestSuite
    {
        [Test]
        public void InitialTest()
        {
            LoginPage loginPage = new LoginPage(WebDriver);
            loginPage.LoadPage();
            loginPage.UsernameInput.Clear();
            loginPage.UsernameInput.Type("standard_user");
            loginPage.PasswordInput.Clear();
            loginPage.PasswordInput.Type("secret_sauce");
            loginPage.LoginButton.Click();
            Console.Read();
        }
    }
}