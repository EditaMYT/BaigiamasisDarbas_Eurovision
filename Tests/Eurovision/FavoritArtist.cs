using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class FavoritArtist : BaseTest
    {
        [Test]
        public void ThirdOption()
        {
            Event.ClickLiverpool2023();
            Event.ClickTheShows();
            Event.ClickParticipants();
            Event.ClickThirdOption();
        }
    }
}
