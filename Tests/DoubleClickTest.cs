using AutomationFramework.Core;
using AutomationFramework.Pages;

namespace AutomationFramework.Tests;

[TestClass]
public class DoubleClickTest : BaseClass
{
    DoubleClickPage doubleClickPage;

    [TestInitialize]
    public void TestSetup()
    {
        driver.Navigate().GoToUrl(
            ConfigReader.GetData("demoqa", "DoubleClickUrl"));
        doubleClickPage = new DoubleClickPage(driver);
    }
    [TestMethod]
    public void VerifyDoubleClickFunctionality()
    {
        doubleClickPage.DoubleClickBtn();
        string actualText = doubleClickPage.GetMessageText();
        Assert.AreEqual("You have done a double click", actualText);
    }
}
