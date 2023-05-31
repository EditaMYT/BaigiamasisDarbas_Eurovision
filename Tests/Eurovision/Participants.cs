using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class Participants
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            Event.Open();
            Event.AcceptCookies();
        }

        [Test]
        public void AllContestants()
        {
            Event.ClickTheShows();
            Event.ClickGrandFinal();
            Event.ClickRank();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
