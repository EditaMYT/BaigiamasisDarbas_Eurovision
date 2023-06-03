namespace Framework.Pages
{
    public class About
    {
        public static void Open()
        {
            Driver.OpenPage("https://eurovision.tv/");
        }

        public static void ClickAbout()
        {
            string locator = "(//*[@id='header']//*[contains(@class,'button-menu')])[12]";
            Common.Click(locator);
        }

        public static void ClickVotingProcedures2023()
        {
            string locator = "(//*[@id='header']//*[contains(@title,'Voting Procedures 2023')])[1]";
            Common.Click(locator);
        }
    }
}
