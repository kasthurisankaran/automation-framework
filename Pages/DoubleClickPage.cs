using AutomationFramework.Utilities;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;

namespace AutomationFramework;
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

    IWebElement doubleClickBtn => waitHelper.WaitForElementVisible(By.Id("doubleClickBtn"));
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
