using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;


namespace TestSendMailRu
{
    internal class DataProviders
    {
       
        /// <summary>
        /// Тип используемого браузера
        /// </summary>
        internal static BrowserTypeEnum BrowserType = BrowserTypeEnum.Chrome;
        
        /// <summary>
        /// Данные для авторизации в Почту
        /// </summary>
        internal static LoginData TestLogin
        {
            get => new LoginData()
                {
                   UrlMailLink = "https://mail.ru",
                   UserName = "antique94",
                   Password = "TestMail2018"
                };
        }

        /// <summary>
        /// Информация для отпраки письма
        /// </summary>
        internal static LetterData TestLetterBody
        {
            get => new LetterData()
                {
                    Sender = GetId(),
                    Recipient = "page" + (long)(DateTime.Now - DateTime.MinValue).TotalSeconds + "@mail.me",
                    Theme = GetTheme(),
                    Body = "Hello! \nThis is a test letter. Please, do not answer.",
                    Signature = "\n\n@Developed by KhrulSA-Corp"
                };
        }

        /// <summary>
        /// Получение драйвера браузера в соответствии с требованиями 
        /// </summary>
        /// <returns>Драйвер браузера</returns>
        internal static IWebDriver GetDriverInstance()
        {
            switch (BrowserType)
            {
                case BrowserTypeEnum.Chrome:
                    return new ChromeDriver();
                case BrowserTypeEnum.Edge:
                    return new EdgeDriver();
                case BrowserTypeEnum.FireFox:
                    return new FirefoxDriver();
            }
            return null;
        }

        internal enum BrowserTypeEnum
        {
            Chrome,
            FireFox,
            Edge
        }

        private static Random rand = new Random();


      private static string GetId()
        {
            string tmp = "";
            for (int i = 0; i < 9; i++)
                tmp += rand.Next(0, 9);
            return tmp;
        }
        private static string GetTheme()
        {
            string tmp = "";
            for (int i = 0; i < 6; i++)
                tmp += (char)rand.Next(0x0410, 0x44F);
            return tmp;
        }
    }
}
