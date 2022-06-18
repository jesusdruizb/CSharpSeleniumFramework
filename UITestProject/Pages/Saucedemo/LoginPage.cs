using System;
using System.Collections;
using OpenQA.Selenium;
using UITestProject.Components;
using UITestProject.Components.Saucedemo;
using UITestProject.Tests.Constants;

namespace UITestProject.Tests.Pages.Saucedemo
{
    public class LoginPage: BasePage
    {
        //private const string usernameLocator = "[data-test='username']";
        //private const string passwordLocator = "[data-test='password']";
        //private const string loginButtonLocator = "[data-test='login-button']";
        private readonly By usernameInputLocatorBy = By.CssSelector("[data-test='username']");
        private readonly By passwordInputLocatorBy = By.CssSelector("[data-test='password']");
        private readonly By loginButtonLocatorBy = By.CssSelector("[data-test='login-button']");

        private const string pageUrl = "https://www.saucedemo.com";
        public Input usernameInput { get; }
        public Input passwordInput { get; }
        public Button loginButton { get; }

        
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
            this.usernameInput = new Input(webDriver, usernameInputLocatorBy);
            this.passwordInput = new Input(webDriver, passwordInputLocatorBy);
            this.loginButton = new Button(webDriver, loginButtonLocatorBy);

        }

        public void LoadPage()
        {
            NavigateTo(pageUrl);
        }
    }
}