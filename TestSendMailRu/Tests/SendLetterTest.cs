using System;
using NUnit.Framework;


namespace TestSendMailRu
{
    [TestFixture]
    internal class SendLetterTest
    {
        internal Application App;

        [SetUp]
        internal void SetUp()
        {
            App = new Application();
        }

        [Test]
        internal void LoginAndSendLetter()
        {
            App.LoginInMail();;
            Assert.IsTrue(App.SendLetter());
        }

        [TearDown]
        internal void TearDown()
        {
            App.Quit();
            App = null;
        }
    }
}
