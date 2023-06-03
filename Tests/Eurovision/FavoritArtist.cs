using Framework;
using Framework.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests.Eurovision
{
    internal class FavoritArtist : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Event.Open();
            Event.AcceptCookies();
        }

        [Test]
        public void ThirdOption()
        {
            Event.ClickLiverpool2023();
            Event.ClickTheShows();
            Event.ClickParticipants();
            Event.ClickThirdOption();
            
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string screenshotFilePath = Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(screenshotFilePath);
            }
        }
    }
}
