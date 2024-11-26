using TechTalk.SpecFlow;
using POM;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly LoginPage loginPage;

        public LoginStepDefinitions()
        {
            loginPage = new LoginPage();
        }

        [Given("User is on the login page")]
        public void GivenUserIsOnTheLoginPage()
        {
            loginPage.NavigateToLoginPage();
        }

        [When("User enters valid credentials")]
        public void WhenUserEntersValidCredentials()
        {
            loginPage.EnterValidCredentials();
        }

        [When("User enters invalid credentials")]
        public void WhenUserEntersInvalidCredentials()
        {
            loginPage.EnterInvalidCredentials();
        }

        [When("User leaves the username field empty")]
        public void WhenUserLeavesUsernameFieldEmpty()
        {
            loginPage.LeaveUsernameFieldEmpty();
        }

        [When("User enters a valid password")]
        public void WhenUserEntersValidPassword()
        {
            loginPage.EnterValidPassword();
        }

        [When("User leaves the password field empty")]
        public void WhenUserLeavesPasswordFieldEmpty()
        {
            loginPage.LeavePasswordFieldEmpty();
        }

        [When("User clicks the login button")]
        public void WhenUserClicksLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then("User should be logged in successfully")]
        public void ThenUserShouldBeLoggedInSuccessfully()
        {
            loginPage.VerifySuccessfulLogin();
        }

        [Then("User should see an error message")]
        public void ThenUserShouldSeeErrorMessage()
        {
            loginPage.VerifyErrorMessageDisplayed();
        }

        [Then("User should see an error message about entering a username")]
        public void ThenUserShouldSeeErrorMessageAboutEnteringUsername()
        {
            loginPage.VerifyErrorMessageForEmptyUsername();
        }

        [Then("User should see an error message about entering a password")]
        public void ThenUserShouldSeeErrorMessageAboutEnteringPassword()
        {
            loginPage.VerifyErrorMessageForEmptyPassword();
        }
    }
}