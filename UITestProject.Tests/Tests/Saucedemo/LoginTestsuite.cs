using NUnit.Framework;
using System;

namespace UITestProject.Tests.Saucedemo
{
    public class LoginTestsuite:BaseTestSuite
    {
        [Test]
        public void InitialTest()
        {
            WebDriver.Navigate().GoToUrl("https://www.saucedemo.com");
            Console.Read();
        }
    }
}