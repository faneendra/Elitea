using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SpecFlowProject1.Utilities
{
    public static class Utilities
    {
        public static IWebDriver Driver { get; set; }

        public static void InitializeDriver(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public static void WaitForElementVisible(By locator, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(driver => driver.FindElement(locator).Displayed);
        }

        public static void NavigateToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }
    }
}