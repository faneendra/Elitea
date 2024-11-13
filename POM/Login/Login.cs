using OpenQA.Selenium;

namespace POM.Login
{
    public class Login
    {
        protected By UserName => By.Name("user-name");
        protected By Password => By.XPath("//input[@name='password' and @id = 'password']");
        protected By SubmitButton => By.Id("login-button");
    }
}
