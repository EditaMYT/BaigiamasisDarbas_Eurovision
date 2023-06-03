using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

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
            string locator = "(//*[@id='onetrust-banner-sdk']//button)[3]";
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.XPath(locator)));
            Common.Click(locator);
        }

        public static void ClickLiverpool2023()
        {
            string locator = "(//*[@id='header']//*[contains(@class,'button-menu')])[7]";
            Common.Click(locator);
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
            string locator = "//*[@id='content']/section/div/div[2]/div/div/div[2]/div[1]/div/div/div/article[3]";
            Common.Click(locator);
        }
    }
}
