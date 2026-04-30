using OpenQA.Selenium;
namespace AutomationFramework.Core;
public class BaseClass
{
    protected IWebDriver driver;
    [TestInitialize]
    public void Setup()
    {
        string browser = ConfigReader.GetBrowser();
        driver = DriverFactory.InitDriver(browser);
    }
    [TestCleanup]
    public void Cleanup()
    {
        DriverFactory.QuitDriver();
    }
}
