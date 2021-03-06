﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace TestSendMailRu
{
    internal class HomePageMailRu : PageBase
    {
       internal HomePageMailRu(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "PH_logoutLink")]
        internal IWebElement LogoutButtonLocator;
        [FindsBy(How = How.XPath, Using = "//span[@class='b-toolbar__btn__text b-toolbar__btn__text_pad']")]
        internal IWebElement NewMailLocator;

        /// <summary>
        /// Выход из почты
        /// </summary>
        internal void LogoutMail()
        {
            LogoutButtonLocator.Click();
        }

        /// <summary>
        /// Создание нового письма
        /// </summary>
        internal void CreateNewLetter()
        {
            //NewMailLocator.SendKeys("N");
            NewMailLocator.Click();
        }

        internal bool IsLoginSucessful()
        {
            try
            {
                wait.Until(ExpectedConditions.ElementExists(By.ClassName("pm-logo__link__pic")));
                return true;

            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }

        internal bool IsSendingNewLetterSucessful()
        {
            try
            {
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='message-sent__title']")));
                return true;

            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }
    }
}
