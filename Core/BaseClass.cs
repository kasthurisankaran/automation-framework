using OpenQA.Selenium;
namespace AutomationFramework.Core;
public class BaseClass
{
    protected IWebDriver driver;
    [TestInitialize]
    public void Setup()
    {
        string browser = ConfigReader.GetBrowser();
        string url=ConfigReader.GetData("demoqa", "DoubleClickUrl");
        driver = DriverFactory.InitDriver(browser);
        driver.Navigate().GoToUrl(url);
    }
    [TestCleanup]
    public void Cleanup()
    {
        DriverFactory.QuitDriver();
    }
}
