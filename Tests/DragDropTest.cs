using AutomationFramework.Pages;
using AutomationFramework.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace AutomationFramework;

[TestClass]
public class DragDropTest:BaseClass
{
    DragDropPage dragDropPage;

    [TestInitialize]
    public void Setup()
    {
        StartBrowser();
        dragDropPage = new DragDropPage(driver);
    }
    [TestMethod]
    public void VerifyDragDropFunctionality()
    {
        dragDropPage.PerformDragAndDrop();
        string sourceText = dragDropPage.GetSourceText();
        string targetText = dragDropPage.GetTargetText();
        Assert.AreEqual("B", sourceText);
        Assert.AreEqual("A", targetText);
    }
    [TestCleanup]
    public void TearDown()
    {
        CloseBrowser(); 
    }
}
