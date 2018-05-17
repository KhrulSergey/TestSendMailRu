using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestSendMailRu
{
    internal class SendLetterPage : PageBase
    {
        public SendLetterPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//textarea[contains(@id, 'toolkit-')]")]
        internal IWebElement LetterBodyFrameLocator;
        [FindsBy(How = How.XPath, Using = "//textarea[@data-original-name = 'To']")]
        internal IWebElement LetterRecipientLocator;
        [FindsBy(How = How.Name, Using = "Subject")]
        internal IWebElement LetterSubjectLocator;
        [FindsBy(How = How.XPath, Using = "//span[text()='Отправить']")]
        internal IWebElement SendButtonLocator;

        internal String letterBodyTextAreaId = "tinymce";

        private void FillBody(String LetterBodyText)
        {
            String frameName = LetterBodyFrameLocator.GetAttribute("id");
            driver.SwitchTo().Frame(frameName + "_ifr");

            var letterBodyTextArea = driver.FindElement(By.Id(letterBodyTextAreaId));

            letterBodyTextArea.SendKeys(LetterBodyText);
            driver.SwitchTo().ParentFrame();
        }


        private void FillLetter(LetterData letterData)
        {
            LetterRecipientLocator.SendKeys(letterData.Recipient);
            LetterSubjectLocator.SendKeys(letterData.Theme);
            FillBody(letterData.Body + letterData.Signature);
        }

        public void SendLetter(LetterData letterData)
        {
            this.FillLetter(letterData);
            SendButtonLocator.Click();
            //LetterSubjectLocator.SendKeys(Keys.Control + Keys.Return);
        }
        
        internal bool IsOpenNewLetterSucessful()
        {
            try
            {
                //wait.Until(ExpectedConditions.ElementExists(By.CssSelector("letter")));
                return true;

            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }

    }
}
