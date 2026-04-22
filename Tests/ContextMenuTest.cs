using AutomationFramework.Pages;
using AutomationFramework.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationFramework.Tests;

[TestClass]
public class ContextMenuTest:BaseClass
{
    ContextMenuPage contextMenuPage;

    [TestInitialize]
    public void Setup()
    {
        StartBrowser();
        NavigateToUrl("internetRightClick", "contextMenuUrl");
        contextMenuPage = new ContextMenuPage(driver);
    }
    [TestMethod]
    public void VerifyRightClickFunctionality()
    {
        contextMenuPage.RightClickOnBox();
        string alertText = contextMenuPage.GetAlertText();
        Assert.AreEqual("You selected a context menu",alertText);
        contextMenuPage.AcceptAlert();
    }
    [TestCleanup]
    public void TearDown()
    {
        CloseBrowser();
    }
}
