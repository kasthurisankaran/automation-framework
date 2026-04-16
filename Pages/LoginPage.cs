using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class LoginPage
    {
        IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement username => driver.FindElement(By.Id("user-name"));
        IWebElement password => driver.FindElement(By.Id("password"));
        IWebElement loginBtn => driver.FindElement(By.Id("login-button"));

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