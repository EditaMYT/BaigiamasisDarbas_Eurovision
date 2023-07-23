using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class Voting : BaseTest
    {
        [Test]
        public void HowToVote()
        {
            About.ClickAbout();
            About.ClickVotingProcedures2023();
        }
    }
}
