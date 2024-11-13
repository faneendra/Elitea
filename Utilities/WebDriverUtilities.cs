using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SpecFlowProject1.Utilities
{
    public static class WebDriverUtilities
    {
        public static void WaitForElementVisible(IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                //wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
        }
    }
}