using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class Participants
    {
        [Test]
        public void AllContestants()
        {
            Driver.InitializeDriver();

            Event.Open();
            Event.ClickTheShows();
            Event.ClickGrandFinal();
            Event.ClickRank();

            Driver.ShutdownDriver();
        }
    }
}
