using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System.IO;
using Newtonsoft.Json.Linq;

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
            string url = configData["baseUrl"].ToString();
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        public string GetData(string key)
        {
            return configData[key].ToString();
        }

        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}