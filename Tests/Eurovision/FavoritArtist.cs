using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class FavoritArtist : BaseTest
    {
        [Test]
        public void ThirdOption()
        {
            Event.OpenEventPage("liverpool", "2023");
            Event.ClickParticipants();
            Event.ClickThirdOption();
        }
    }
}
