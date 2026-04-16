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
            loginPage.Login("standard_user", "secret_sauce");

            System.Threading.Thread.Sleep(3000);

            CloseBrowser();
        }
    }
}