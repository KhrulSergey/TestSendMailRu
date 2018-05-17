using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestSendMailRu
{
    public class LoginPageMailRu : PageBase
    {
        public LoginPageMailRu(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "login")]
        public IWebElement UsernameLocator;
        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement PasswordLocator;
        [FindsBy(How = How.Id, Using = "mailbox:submit")]
        public IWebElement LoginButtonLocator;

        private void UserNameInputField(String username)
        {
            UsernameLocator.SendKeys(username);
            
        }
        private void PasswordInputField(String password)
        {
            PasswordLocator.SendKeys(password);
        }
        
        private void SubmitLogin()
        {
            LoginButtonLocator.Click();
        }

        public void LoginAs(LoginData loginData)
        {
            UserNameInputField(loginData.UserName);
            PasswordInputField(loginData.Password);
            SubmitLogin();
        }

        public void OpenLoginPage(String linkTarget = "http://mail.ru")
        {
            driver.Url = linkTarget;
        }

        internal bool IsUrlOpenedSucessful()
        {
            try
            {
                //wait.Until(ExpectedConditions.ElementExists(By.CssSelector("mail")));
                return true;

            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }
    }
}
