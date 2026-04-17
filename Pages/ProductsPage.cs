using OpenQA.Selenium;
using AutomationFramework.Utilities;

namespace AutomationFramework.Pages
{
    public class ProductsPage
    {
        IWebDriver driver;
        WaitHelper waitHelper;

        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
            waitHelper = new WaitHelper(driver);
        }

        IWebElement pageTitle => waitHelper.WaitForElementVisible(By.ClassName("title"));

        public bool IsProductsPageDisplayed()
        {
            try
            {
                return pageTitle.Text.Equals("Products");
            }
            catch
            {
                return false;
            }
        }
    }
}
