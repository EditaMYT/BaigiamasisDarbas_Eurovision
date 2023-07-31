using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class LatestNews : BaseTest
    {
        [Test]
        public void FirstNews()
        {
            Latest.ClickFirstRadioButton();
            Latest.ClickReadMore();
        }
    }
}
