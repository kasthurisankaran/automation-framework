using OpenQA.Selenium;
using AutomationFramework.Utilities;
namespace AutomationFramework;

public class ContextMenuPage
{
    IWebDriver driver;
    WaitHelper waitHelper;
    ActionsHelper actionsHelper;

    public ContextMenuPage(IWebDriver driver)
    {
        this.driver = driver;
        waitHelper = new WaitHelper(driver);
        actionsHelper = new ActionsHelper(driver);
    }
    IWebElement box => waitHelper.WaitForElementVisible(By.Id("hot-spot"));
    public void RightClickOnBox()
    {
        actionsHelper.RightClick(box);
        Thread.Sleep(2000);
    }
    public string GetAlertText()
    {
        return driver.SwitchTo().Alert().Text;
    }
    public void AcceptAlert()
    {
        driver.SwitchTo().Alert().Accept();
    }
}
