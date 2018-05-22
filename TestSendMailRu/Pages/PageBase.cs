using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestSendMailRu
{
    internal class PageBase
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        internal PageBase(IWebDriver driver)
        {
            this.driver = driver;

            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
    }
}
