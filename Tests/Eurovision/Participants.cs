using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class Participants : BaseTest
    {
        [Test]
        public void AllContestants()
        {
            Event.ClickLiverpool2023();
            Event.ClickTheShows();
            Event.ClickGrandFinal();
            Event.ClickRank();
        }
    }
}
