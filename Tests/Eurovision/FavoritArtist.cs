using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class FavoritArtist
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            Event.Open();
            Event.AcceptCookies();
        }

        [Test]
        public void ThirdOption()
        {
            Event.ClickTheShows();
            Event.ClickParticipants();
            Event.ClickThirdOption();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
