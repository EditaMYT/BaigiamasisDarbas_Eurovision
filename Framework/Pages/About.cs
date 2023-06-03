using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Pages
{
    public class About
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
