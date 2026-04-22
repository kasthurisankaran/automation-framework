using OpenQA.Selenium;
using AutomationFramework.Utilities;

namespace AutomationFramework.Pages
{
    public class HoverPage
    {
        IWebDriver driver;
        WaitHelper waitHelper;
        ActionsHelper actionsHelper;

        public HoverPage(IWebDriver driver)
        {
            this.driver = driver;
            waitHelper = new WaitHelper(driver);
            actionsHelper = new ActionsHelper(driver);
        }
        public void HoverOnImage(int index)
        {
            var image= waitHelper.WaitForElementVisible
                (By.XPath($"(//div[@class='figure'])[{index}]"));
            actionsHelper.MouseHover(image);
        }
        public IWebElement GetHoverText(int index)
        {
            return waitHelper.WaitForElementVisible
                (By.XPath($"(//div[@class='figure'])[{index}]//h5"));
        }
    }
}