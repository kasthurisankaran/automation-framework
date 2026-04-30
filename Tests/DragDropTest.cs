using AutomationFramework.Core;
using AutomationFramework.Pages;

namespace AutomationFramework.Tests
{
    [TestClass]
    public class DragDropTest : BaseClass
    {
        DragDropPage dragDropPage;

        [TestInitialize]
        public void TestSetup()
        {
            driver.Navigate().GoToUrl(
                ConfigReader.GetData("internetDragDrop", "dragDropUrl"));
            dragDropPage = new DragDropPage(driver);
        }
        [TestMethod]
        public void VerifyDragAndDrop()
        {
            dragDropPage.DragAndDrop();

            string sourceText = dragDropPage.GetSourceText();
            string targetText = dragDropPage.GetTargetText();

            Assert.AreEqual("B", sourceText);
            Assert.AreEqual("A", targetText);
        }
    }
}