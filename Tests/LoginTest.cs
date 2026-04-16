using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationFramework.Utilities;
using AutomationFramework.Pages;

namespace AutomationFramework.Tests
{
    [TestClass]
    public class LoginTest : BaseClass
    {
        [TestMethod]
        public void ValidLoginTest()
        {
            StartBrowser();

            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("standard_user", "secret_sauce");

            System.Threading.Thread.Sleep(3000);

            CloseBrowser();
        }
    }
}