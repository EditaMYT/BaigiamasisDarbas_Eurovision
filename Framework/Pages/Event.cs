namespace Framework.Pages
{
    public class Event
    {
        public static void OpenEventPage(string city, string year)
        {
            Driver.OpenPage($"https://eurovision.tv/event/{city}-{year}");
        }

        public static void ClickTheShows()
        {
            string locator = "(//*[@id='header']//*[contains(@class,'button-menu')])[8]";
            Common.Click(locator);
        }

        public static void ClickGrandFinal()
        {
            string locator = "(//*[@id='content']//*[contains(@class,'js-tab-item')])[5]";
            Common.Click(locator);
        }

        public static void ClickRank()
        {
            string locator = "//*[@id='view-field-participation-rank-table-column']";
            Common.Click(locator);
        }

        public static void ClickParticipants()
        {
            string locator = "(//*[@id='content']//*[contains(@class,'js-tab-item')])[2]";
            Common.Click(locator);
        }

        public static void ClickThirdOption()
        {
            string locator = "(//*[@id='content']//*[contains(@class,'watch-item')])[15]";
            Common.Click(locator);
        }
    }
}
