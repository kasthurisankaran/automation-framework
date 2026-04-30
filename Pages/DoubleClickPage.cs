using AutomationFramework.Utilities;
using OpenQA.Selenium;

namespace AutomationFramework.Pages;

public class DoubleClickPage
{
    IWebDriver driver;
    WaitHelper waitHelper;
    ActionsHelper actionsHelper;

    public DoubleClickPage(IWebDriver driver)
    {
        this.driver = driver;
        waitHelper = new WaitHelper(driver);
        actionsHelper = new ActionsHelper(driver);
    }

    IWebElement doubleClickBtn => waitHelper.WaitForElementClickable(By.Id("doubleClickBtn"));
    IWebElement message => waitHelper.WaitForElementVisible(By.Id("doubleClickMessage"));

    public void DoubleClickBtn()
    {
        actionsHelper.DoubleClick(doubleClickBtn);
    }

    public string GetMessageText()
    {
        return message.Text;
    }
}