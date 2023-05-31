using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class LatestNews
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            Latest.Open();
            Latest.AcceptCookies();
        }

        [Test]
        public void FirstNews()
        {
            Latest.ClickFirstRadioButton();
            Latest.ClickReadMore();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
