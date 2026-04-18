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

        IWebElement firstImage => waitHelper.WaitForElementVisible(By.XPath("(//div[@class='figure'])[1]"));

        public void HoverOnFirstImage()
        {
            actionsHelper.MouseHover(firstImage);
        }
    }
}