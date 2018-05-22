using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestSendMailRu
{
    internal class LoginPageMailRu : PageBase
    {
        internal LoginPageMailRu(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "login")]
        internal IWebElement UsernameLocator;
        [FindsBy(How = How.Name, Using = "password")]
        internal IWebElement PasswordLocator;
        [FindsBy(How = How.Id, Using = "mailbox:submit")]
        internal IWebElement LoginButtonLocator;

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

        internal void LoginAs(LoginData loginData)
        {
            UserNameInputField(loginData.UserName);
            PasswordInputField(loginData.Password);
            SubmitLogin();
        }

        internal void OpenLoginPage(String linkTarget = "http://mail.ru")
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
