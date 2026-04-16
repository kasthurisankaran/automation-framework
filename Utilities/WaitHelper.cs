using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

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
    }
}