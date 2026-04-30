using AutomationFramework.Core;
using AutomationFramework.Pages;
using AutomationFramework.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationFramework.Tests;

[TestClass]
public class DoubleClickTest : BaseClass
{
    DoubleClickPage doubleClickPage;

    [TestInitialize]
    public void TestSetup()
    {
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
