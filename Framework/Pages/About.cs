namespace Framework.Pages
{
    public class About
    {
        public static void ClickVotingProcedures2023()
        {
            Driver.OpenPage("https://eurovision.tv/");
        }

        public static void Open()
        {
            string locator = "//*[@id='header']/div/div/div[2]/nav/ul/li[6]/ul/li[7]/a";
            Common.Click(locator);
        }
    }
}
