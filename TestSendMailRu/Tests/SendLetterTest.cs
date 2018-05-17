using System;
using NUnit.Framework;


namespace TestSendMailRu
{
    [TestFixture]
    public class SendLetterTest
    {
        public Application App;

        [SetUp]
        public void SetUp()
        {
            App = new Application();
        }

        [Test]
        public void LoginAndSendLetter()
        {
            App.LoginInMail();;
            Assert.IsTrue(App.SendLetter());
        }

        [TearDown]
        public void TearDown()
        {
            App.Quit();
            App = null;
        }
    }
}
