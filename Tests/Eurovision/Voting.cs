using Framework;
using Framework.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests.Eurovision
{
    internal class Voting : BaseTest
    {
        [Test]
        public void HowToVote()
        {
            About.ClickAbout();
            About.ClickVotingProcedures2023();

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string screenshotFilePath = Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(screenshotFilePath);
            }
        }
    }
}
