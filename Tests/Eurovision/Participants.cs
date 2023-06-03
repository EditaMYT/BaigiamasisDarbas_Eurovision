using Framework;
using Framework.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests.Eurovision
{
    internal class Participants : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Event.Open();
            Home.AcceptCookies();
        }

        [Test]
        public void AllContestants()
        {
            Event.ClickLiverpool2023();
            Event.ClickTheShows();
            Event.ClickGrandFinal();
            Event.ClickRank();

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string screenshotFilePath = Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(screenshotFilePath);
            }
        }
    }
}
