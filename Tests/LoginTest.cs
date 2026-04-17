using AutomationFramework.Pages;
using AutomationFramework.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace AutomationFramework.Tests
{
    [TestClass]
    public class LoginTest : BaseClass
    {
        [TestMethod]
        public void ValidLoginTest()
        {
            StartBrowser();
            try
            {
                driver.SwitchTo().Alert().Accept();
            }
            catch (NoAlertPresentException)
            {
            }

            LoginPage loginPage = new LoginPage(driver);
            string username = GetData("username");
            string password = GetData("password");
            Assert.IsTrue(loginPage.IsLoginButtonDisplayed());
            loginPage.Login(username, password);
            Assert.IsTrue(driver.Url.Contains("inventory"));

            Thread.Sleep(3000);

            CloseBrowser();
        }
    }
}