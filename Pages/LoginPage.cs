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

        IWebElement username => waitHelper.WaitForElement(By.Id("user-name"));
        IWebElement password => waitHelper.WaitForElement(By.Id("password"));
        IWebElement loginBtn => waitHelper.WaitForElement(By.Id("login-button"));

        public void EnterUsername(string user)
        {
            username.SendKeys(user);
        }

        public void EnterPassword(string pass)
        {
            password.SendKeys(pass);
        }

        public void ClickLogin()
        {
            loginBtn.Click();
        }

        public void Login(string user, string pass)
        {
            EnterUsername(user);
            EnterPassword(pass);
            ClickLogin();
        }
    }
}