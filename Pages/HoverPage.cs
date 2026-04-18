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
        IWebElement SecondImage => waitHelper.WaitForElementVisible(By.XPath("(//div[@class='figure'])[2]"));
        IWebElement ThirdImage => waitHelper.WaitForElementVisible(By.XPath("(//div[@class='figure'])[3]"));
        public void HoverOnFirstImage()
        {
            actionsHelper.MouseHover(firstImage);
            Thread.Sleep(2000);
        }
        public void HoverOnSecondImage()
        {
            actionsHelper.MouseHover(SecondImage);
            Thread.Sleep(2000);
        }
        public void HoverOnThirdImage()
        {
            actionsHelper.MouseHover(ThirdImage);
            Thread.Sleep(2000);
        }
    }
}