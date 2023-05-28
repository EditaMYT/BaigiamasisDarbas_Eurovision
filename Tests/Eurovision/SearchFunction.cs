using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class SearchFunction
    {
        [Test]
        public void SearchField()
        {
            string expectedResult = "Lithuania 2023";
            
            Driver.InitializeDriver();
            Search.Open();

            Search.EnterMessage(expectedResult);
            Search.ClickSearchIcon();
            string actualResult = Search.GetMessage();

            Assert.AreEqual(expectedResult, actualResult);

            Driver.ShutdownDriver();
        }
    }
}
