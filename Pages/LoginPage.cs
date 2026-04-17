using OpenQA.Selenium;
using AutomationFramework.Utilities;

namespace AutomationFramework.Pages
{
    public class LoginPage
    {
        IWebDriver driver;
        WaitHelper waitHelper;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            waitHelper = new WaitHelper(driver);
        }

        IWebElement username => waitHelper.WaitForElementVisible(By.Id("user-name"));
        IWebElement password => waitHelper.WaitForElementVisible(By.Id("password"));
        IWebElement loginBtn => waitHelper.WaitForElementClickable(By.Id("login-button"));

        public void EnterUsername(string user)
        {
            username.Clear();
            username.SendKeys(user);
        }

        public void EnterPassword(string pass)
        {
            password.Clear();
            password.SendKeys(pass);
        }
        public void ClickLogin()
        {
            loginBtn.Click();
        }
        public bool IsLoginButtonDisplayed()
        {
            try
            {
                return loginBtn.Displayed;
            }
            catch
            {
                return false;
            }
        }

        public void Login(string user, string pass)
        {
            EnterUsername(user);
            EnterPassword(pass);
            ClickLogin();
        }
    }
}