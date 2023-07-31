using Framework.Pages;
using NUnit.Framework;

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
        }
    }
}
