using NUnit.Framework;
using OpenQA.Selenium;
using POM.Login;
using SauceDemoAutomation.POM;

namespace SauceDemoAutomation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly LoginPage _loginPage;

        public LoginStepDefinitions(IWebDriver driver)
        {
            _loginPage = new LoginPage(driver);
        }

        [Given("I am on the SauceDemo login page")]
        public void GivenIAmOnTheSauceDemoLoginPage()
        {
            _loginPage.NavigateToLoginPage();
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            _loginPage.EnterCredentials("standard_user", "secret_sauce");
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            Assert.IsTrue(_loginPage.IsProductsPageDisplayed());
        }
    }
}