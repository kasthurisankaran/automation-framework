using AutomationFramework.Pages;
using AutomationFramework.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace AutomationFramework.Tests
{
    [TestClass]
    public class LoginTest : BaseClass
    {
        LoginPage loginPage;
        ProductsPage productsPage;

        [TestInitialize]
        public void Setup()
        {
            StartBrowser();

            loginPage = new LoginPage(driver);
            productsPage = new ProductsPage(driver);
        }
        [TestMethod]
        public void ValidLoginTest()
        {
            string username = GetData("username");
            string password = GetData("password");
            Assert.IsTrue(loginPage.IsLoginButtonDisplayed());
            loginPage.Login(username, password);
            Assert.IsTrue(driver.Url.Contains("inventory"));
            Assert.IsTrue(productsPage.IsProductsPageDisplayed());
        }
        [TestCleanup]
        public void TearDown()
        {
            CloseBrowser();
        }
    }
}