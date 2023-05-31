namespace Framework.Pages
{
    public class Event
    {
        public static void Open()
        {
            Driver.OpenPage("https://eurovision.tv/");
        }

        public static void AcceptCookies()
        {
            string locator = "//*[@id='onetrust-accept-btn-handler']";
            Common.Click(locator);
        }

        public static void ClickTheShows()
        {
            string locator = "//*[@id='header']/div/div/div[2]/nav/ul/li[3]/ul/li[1]/a";
            Common.Click(locator);
        }

        public static void ClickGrandFinal()
        {
            string locator = "//*[@id='content']/section/div/div[1]/div[2]/div/div/div[2]/a[5]";
            Common.Click(locator);
        }

        public static void ClickRank()
        {
            string locator = "//*[@id='view-field-participation-rank-table-column']";
            Common.Click(locator);
        }

        public static void ClickParticipants()
        {
            string locator = "//*[@id='content']/section/div/div[1]/div[2]/div/div/div[2]/a[2]";
            Common.Click(locator);
        }

        public static void ClickThirdOption()
        {
            string locator = "//*[@id='content']/section/div/div[2]/div/div/div[2]/div[1]/div/div/div/article[3]";
            Common.Click(locator);
        }
    }
}
