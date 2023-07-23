using Framework;
using Framework.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests.Eurovision
{
    internal class SearchFunction : BaseTest
    {
        [Test]
        public void SearchField()
        {
            string expectedResult = "Lithuania 2023";
            
            Search.ClickSearchIcon();
            Search.EnterMessage(expectedResult);
            Search.ClickSearchIconInSearchBox();
            
            string actualResult = Search.GetMessage();

            Assert.AreEqual(expectedResult, actualResult);

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string screenshotFilePath = Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(screenshotFilePath);
            }
        }
    }
}
