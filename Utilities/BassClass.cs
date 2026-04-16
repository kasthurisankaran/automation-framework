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

        public void StartBrowser()
        {
            // Read URL from config file
            var json = File.ReadAllText("Config/config.json");
            var data = JObject.Parse(json);
            string url = data["baseUrl"].ToString();

            // Setup Chrome driver automatically
            new DriverManager().SetUpDriver(new ChromeConfig());

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}