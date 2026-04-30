using AutomationFramework.Core;
using AutomationFramework.Pages;

namespace AutomationFramework.Tests
{
    [TestClass]
    public class HoverTest : BaseClass
    {
        HoverPage hoverPage;
        [TestInitialize]
        public void TestSetup()
        {
            driver.Navigate().GoToUrl(
                ConfigReader.GetData("internetMouseHover", "hoverUrl"));
            hoverPage = new HoverPage(driver);
        }
        [TestMethod]
        public void VerifyHoverFunctionality()
        {
            hoverPage.HoverOnImage(1);
            Assert.IsTrue(hoverPage.GetHoverText(1).Displayed);
            Assert.AreEqual("name: user1", hoverPage.GetHoverText(1).Text);

            hoverPage.HoverOnImage(2);
            Assert.IsTrue(hoverPage.GetHoverText(2).Displayed);
            Assert.AreEqual("name: user2", hoverPage.GetHoverText(2).Text);

            hoverPage.HoverOnImage(3);
            Assert.IsTrue(hoverPage.GetHoverText(3).Displayed);
            Assert.AreEqual("name: user3", hoverPage.GetHoverText(3).Text);
        }
    }
}