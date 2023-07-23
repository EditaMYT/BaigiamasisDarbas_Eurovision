using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class Participants : BaseTest
    {
        [Test]
        public void AllContestants()
        {
            Event.OpenEventPage("liverpool", "2023");
            Event.ClickGrandFinal();
            Event.ClickRank();
        }
    }
}
