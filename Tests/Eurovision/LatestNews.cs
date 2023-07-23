using Framework;
using Framework.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests.Eurovision
{
    internal class LatestNews : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Home.Open();
            Home.AcceptCookies();
        }

        [Test]
        public void FirstNews()
        {
            Latest.ClickFirstRadioButton();
            Latest.ClickReadMore();

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string screenshotFilePath = Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(screenshotFilePath);
            }
        }
    }
}
