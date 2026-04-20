using AutomationFramework.Utilities;
using OpenQA.Selenium;
namespace AutomationFramework.Pages;

public class DragDropPage
{
    IWebDriver driver;
    WaitHelper waitHelper;
    ActionsHelper actionsHelper;

    public DragDropPage(IWebDriver driver)
    {
        this.driver = driver;
        waitHelper = new WaitHelper(driver);
        actionsHelper = new ActionsHelper(driver);
    }
    IWebElement source => waitHelper.WaitForElementVisible(By.Id("column-a"));
    IWebElement target => waitHelper.WaitForElementVisible(By.Id("column-b"));
    public void PerformDragAndDrop()
    {
        actionsHelper.DragAndDrop(source,target);
    }
    public string GetSourceText()
    {
        return source.Text;
    }
    public string GetTargetText()
    {
        return target.Text;
    }
}
