using System;
using OpenQA.Selenium;

namespace TestSendMailRu
{
    internal class Application
    {
        private IWebDriver driver;
        private LoginPageMailRu loginPage;
        private HomePageMailRu homePage;
        private SendLetterPage sendLetterPage;

        internal Application()
        {
            driver = DataProviders.GetDriverInstance();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            loginPage = new LoginPageMailRu(driver);
            homePage = new HomePageMailRu(driver);
            sendLetterPage = new SendLetterPage(driver);
        }

       
        internal bool LoginInMail()
        {
            var loginData = DataProviders.TestLogin;
            loginPage.OpenLoginPage();
            loginPage.LoginAs(loginData);
            return homePage.IsLoginSucessful();
        }

        internal bool SendLetter()
        {
            try
            {
                homePage.CreateNewLetter();
                if (sendLetterPage.IsOpenNewLetterSucessful())
                {
                    var letterData = DataProviders.TestLetterBody;
                    sendLetterPage.SendLetter(letterData);
                    return homePage.IsSendingNewLetterSucessful();
                }
                return false;
            }
            catch (Exception)
            { return false; }

        }

        internal void LogoutFromMail()
        {
            homePage.LogoutMail();
        }

        internal void Quit()
        {
            try
            {
                //LogoutFromMail();
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
    }
}
