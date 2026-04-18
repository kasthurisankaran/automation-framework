using AutomationFramework.Pages;
using AutomationFramework.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationFramework.Tests
{
    [TestClass]
    public class HoverTest : BaseClass
    {
        HoverPage hoverPage;

        [TestInitialize]
        public void Setup()
        {
            StartBrowser();
            hoverPage = new HoverPage(driver);
        }

        [TestMethod]
        public void VerifyHoverFunctionality()
        {
            hoverPage.HoverOnImage(1);
            hoverPage.HoverOnImage(2);
            hoverPage.HoverOnImage(3);

        }

        [TestCleanup]
        public void TearDown()
        {
            CloseBrowser();
        }
    }
}