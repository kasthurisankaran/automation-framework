using OpenQA.Selenium;
using AutomationFramework.Utilities;

namespace AutomationFramework.Pages
{
    public class DragDropPage
    {
        IWebDriver driver;
        WaitHelper waitHelper;

        public DragDropPage(IWebDriver driver)
        {
            this.driver = driver;
            waitHelper = new WaitHelper(driver);
        }

        IWebElement source => waitHelper.WaitForElementVisible(By.Id("column-a"));
        IWebElement target => waitHelper.WaitForElementVisible(By.Id("column-b"));
        public void DragAndDrop()
        {
            DragAndDropUsingJS();
        }
        public void DragAndDropUsingJS()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            string script = @"
                function createEvent(typeOfEvent) {
                    var event = document.createEvent('CustomEvent');
                    event.initCustomEvent(typeOfEvent, true, true, null);
                    event.dataTransfer = {
                        data: {},
                        setData: function(key, value) {
                            this.data[key] = value;
                        },
                        getData: function(key) {
                            return this.data[key];
                        }
                    };
                    return event;
                }

                function dispatchEvent(element, event, transferData) {
                    if (transferData !== undefined) {
                        event.dataTransfer = transferData;
                    }
                    if (element.dispatchEvent) {
                        element.dispatchEvent(event);
                    } else if (element.fireEvent) {
                        element.fireEvent('on' + event.type, event);
                    }
                }

                function simulateDragDrop(sourceNode, destinationNode) {
                    var dragStartEvent = createEvent('dragstart');
                    dispatchEvent(sourceNode, dragStartEvent);

                    var dropEvent = createEvent('drop');
                    dispatchEvent(destinationNode, dropEvent, dragStartEvent.dataTransfer);

                    var dragEndEvent = createEvent('dragend');
                    dispatchEvent(sourceNode, dragEndEvent, dropEvent.dataTransfer);
                }

                simulateDragDrop(arguments[0], arguments[1]);
            ";

            js.ExecuteScript(script, source, target);
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
}