using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace AutomationFramework.Utilities
{
    public class BaseClass
    {
        public static IWebDriver driver;
        JObject configData;

        public void StartBrowser()
        {
            // Read config file once
            var json = File.ReadAllText("Config/config.json");
            configData = JObject.Parse(json);
            string url = configData["internet"]["hoverUrl"].ToString();
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);

            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
                driver.SwitchTo().Alert().Accept();
            }
            catch (WebDriverTimeoutException)
            {
                // No alert appeared — safe to continue
            }
        }

        public string GetData(string section,string key)
        {
            return configData[section][key].ToString();
        }

        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}