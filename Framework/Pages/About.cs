namespace Framework.Pages
{
    public class About
    {
        public static string GetHeadingText()
        {
            string locator = "//h1";
            return Common.GetElementText(locator);
        }
    }
}
