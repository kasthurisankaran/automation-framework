using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AutomationFramework.Utilities;

public class ActionsHelper
{
    IWebDriver driver;
    Actions actions;
    public ActionsHelper(IWebDriver driver)
    {
        this.driver = driver;
        actions=new Actions(driver);
    }
    
    public void MouseHover(IWebElement element)
    {
        actions.MoveToElement(element).Perform();
    }

    public void RightClick(IWebElement element)
    {
        actions.ContextClick(element).Perform();
    }

    public void DoubleClick(IWebElement element)
    {
        actions.DoubleClick(element).Perform();
    }

    public void DragAndDrop(IWebElement target,IWebElement source)
    {
        actions.DragAndDrop(target, source).Perform();
    }

    public void SendKeys(IWebElement element, string text)
    {
        actions.SendKeys(element, text).Perform();
    }

}
