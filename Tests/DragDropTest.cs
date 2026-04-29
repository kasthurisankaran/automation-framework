using AutomationFramework.Core;
using AutomationFramework.Pages;
using AutomationFramework.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationFramework.Tests
{
    [TestClass]
    public class DragDropTest : BaseClass
    {
        DragDropPage dragDropPage;

        [TestInitialize]
        public void TestSetup()
        {
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