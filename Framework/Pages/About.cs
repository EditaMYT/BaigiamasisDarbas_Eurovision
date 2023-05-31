namespace Framework.Pages
{
    public class About
    {
        public static void Open()
        {
            string locator = "https://eurovision.tv/";
            Common.Click(locator);
        }

        public static void AcceptCookies()
        {
            string locator = "//*[@id='onetrust-accept-btn-handler']";
            Common.Click(locator);
        }

        public static void ClickVotingProcedures2023()
        {
            Driver.OpenPage("//*[@id='header']/div/div/div[2]/nav/ul/li[6]/ul/li[7]/a");
        }
    }
}
