using OpenQA.Selenium;

namespace SauceDemoAutomation.POM
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private By _usernameField = By.Id("user-name");
        private By _passwordField = By.Id("password");
        private By _loginButton = By.Id("login-button");

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        public void EnterCredentials(string username, string password)
        {
            _driver.FindElement(_usernameField).SendKeys(username);
            _driver.FindElement(_passwordField).SendKeys(password);
            _driver.FindElement(_loginButton).Click();
        }

        public bool IsProductsPageDisplayed()
        {
            return _driver.Url.Contains("inventory.html");
        }
    }
}