namespace Framework.Pages
{
    public class Latest
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

        public static void ClickFirstRadioButton()
        {
            string locator = "//*[@id='slick-slide-control00']";
            Common.Click(locator);
        }

        public static void ClickReadMore()
        {
            string locator = "//*[@id='slick-slide-control00']";
            Common.Click(locator);
        }
    }
}
