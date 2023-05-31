using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class SearchFunction
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            Search.Open();
            Search.AcceptCookies();
        }

        [Test]
        public void SearchField()
        {
            string expectedResult = "Lithuania 2023";

            Search.EnterMessage(expectedResult);
            Search.ClickSearchIcon();
            string actualResult = Search.GetMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
