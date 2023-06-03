using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Framework.Pages
{
    public class Search
    {
        public static void Open()
        {
            Driver.OpenPage("https://eurovision.tv/");
        }

        public static void AcceptCookies()
        {
            string locator = "(//*[@id='onetrust-banner-sdk']//button)[3]";
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.XPath(locator)));
            Common.Click(locator);
        }

        public static void ClickSearchIcon()
        {
            string locator = "(//*[@id='search-popup-trigger'])[1]";
            Common.Click(locator);
        }

        public static void EnterMessage(string message)
        {
            string locator = "(//*[@id='search-header'])[1]";
            Common.SendKeys(locator, message);
        }

        public static void ClickSearchIconInSearchBox()
        {
            string locator = "(//*[@id='edit-actions-submit'])[1]";
            Common.Click(locator);
        }

        public static string GetMessage()
        {
            string locator = "//*[@id='edit-search']";
            return Common.GetElementText(locator);
        }
    }
}
