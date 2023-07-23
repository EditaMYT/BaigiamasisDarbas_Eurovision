using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class Voting : BaseTest
    {
        [Test]
        public void HowToVote()
        {
            string expectedResult = "How To Vote";

            Home.Menu.ClickAbout();
            Home.Menu.About.ClickVotingProcedures2023();
            string actualText = About.GetHeadingText();

            Assert.AreEqual(expectedResult, actualText);
        }
    }
}
