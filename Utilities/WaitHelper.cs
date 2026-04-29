using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumExtras.WaitHelpers;

namespace AutomationFramework.Utilities
{
    public class WaitHelper
    {
        IWebDriver driver;
        WebDriverWait wait;

        public WaitHelper(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public IWebElement WaitForElement(By locator)
        {
            return wait.Until(d => d.FindElement(locator));
        }
        public IWebElement WaitForElementVisible(By locator)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }
        public IWebElement WaitForElementClickable(By locator)
        {
            return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}
