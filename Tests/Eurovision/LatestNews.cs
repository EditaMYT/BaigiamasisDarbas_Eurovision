using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class LatestNews
    {
        [Test]
        public void FirstNews()
        {
            Driver.InitializeDriver();
            Latest.Open();

            Latest.ClickFirstRadioButton();
            Latest.ClickReadMore();

            Driver.ShutdownDriver();
        }
    }
}
