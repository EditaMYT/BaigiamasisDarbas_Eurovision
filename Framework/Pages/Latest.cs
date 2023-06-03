namespace Framework.Pages
{
    public class Latest
    {
        public static void Open()
        {
            Driver.OpenPage("https://eurovision.tv/");
        }

        public static void ClickFirstRadioButton()
        {
            string locator = "(//*[@id='block-homepage-banner']//button)[3]";
            Common.Click(locator);
        }

        public static void ClickReadMore()
        {
            string locator = "//*[@id='slick-slide00']//*[contains(@class,'item-link')]";
            Common.Click(locator);
        }
    }
}
