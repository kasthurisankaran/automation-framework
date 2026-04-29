using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;

public class DriverFactory
{
	private static IWebDriver driver;

	public static IWebDriver InitDriver(string browser)
	{ 
		if(driver == null)
		{
			switch(browser.ToLower())
			{
				case "chrome":
					driver = new ChromeDriver();
					break;
				case "edge":
					driver = new ChromeDriver();
					break;
				default:
					throw new Exception("Browser not supported");
			}
			driver.Manage().Window.Maximize();
		}
		return driver;
	}
	public static IWebDriver GetDriver()
	{
		return driver; 
	}
	public static void QuitDriver()
	{
		if( driver != null )
		{
			driver.Quit();
			driver = null;
		}
	}
}
