using OpenQA.Selenium;
using UITestProject.Components.Saucedemo;
using UITestProject.Tests.Pages;

namespace UITestProject.Pages.Saucedemo
{
    public class LoginPage: BasePage
    {
        private readonly By _usernameInputLocatorBy = By.CssSelector("[data-test='username']");
        private readonly By _passwordInputLocatorBy = By.CssSelector("[data-test='password']");
        private readonly By _loginButtonLocatorBy = By.CssSelector("[data-test='login-button']");

        private const string PageUrl = "https://www.saucedemo.com";
        public Input UsernameInput { get; }
        public Input PasswordInput { get; }
        public Button LoginButton { get; }

        
        public LoginPage(IWebDriver webDriver, int explicitWaitSeconds = 10) : base(webDriver,explicitWaitSeconds)
        {
            this.UsernameInput = new Input(webDriver, _usernameInputLocatorBy, _Wait);
            this.PasswordInput = new Input(webDriver, _passwordInputLocatorBy, _Wait);
            this.LoginButton = new Button(webDriver, _loginButtonLocatorBy, _Wait);
        }

        public void LoadPage()
        {
            NavigateTo(PageUrl);
        }
    }
}