using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class Voting
    {
        [Test]
        public void HowToVote()
        {
            Driver.InitializeDriver();

            About.Open();
            About.ClickVotingProcedures2023();

            Driver.ShutdownDriver();
        }
    }
}
