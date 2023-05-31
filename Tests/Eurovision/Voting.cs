using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class Voting
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            About.Open();
            About.AcceptCookies();
        }

        [Test]
        public void HowToVote()
        {
            About.ClickVotingProcedures2023();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
