using Framework.Pages;
using NUnit.Framework;

namespace Tests.Eurovision
{
    internal class SearchFunction
    {
        [Test]
        public void SearchField()
        {
            string expectedResut = "Lithuania 2023";

            Search.EnterMessage();
            Search.ClickSearchIcon();
            string actualResult = Search.GetMessage();

            Assert.AreEqual(expectedResut, actualResult);

            driver.Quit();
        }
    }
}
