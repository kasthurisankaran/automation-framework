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
            NavigateToUrl("sauceDemo", "baseUrl");

            loginPage = new LoginPage(driver);
            productsPage = new ProductsPage(driver);
        }
        [TestMethod]
        public void ValidLoginTest()
        {
            string username = GetData("sauceDemo", "username");
            string password = GetData("sauceDemo", "password");
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