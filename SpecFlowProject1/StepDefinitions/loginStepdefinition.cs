using TechTalk.SpecFlow;
using POM;

[Binding]
public class LoginStepDefinitions
{
    private readonly LoginPage _loginPage;

    public LoginStepDefinitions(LoginPage loginPage)
    {
        _loginPage = loginPage;
    }

    [Given("I am on the login page")]
    public void GivenIAmOnTheLoginPage()
    {
        _loginPage.NavigateToLoginPage();
    }

    [When("I enter valid credentials")]
    public void WhenIEnterValidCredentials()
    {
        _loginPage.EnterCredentials("standard_user", "secret_sauce");
    }

    [Then("I should be redirected to the inventory page")]
    public void ThenIShouldBeRedirectedToTheInventoryPage()
    {
        _loginPage.VerifySuccessfulLogin();
    }
}