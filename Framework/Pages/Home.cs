using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Pages
{
    public class Home
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

        public class Menu
        {
            public static void ClickAbout()
            {
                string locator = "//*[@id='header']//nav[not(contains(@class,'mobile'))]/ul/li[4]";
                Common.WaitForElementToBeVisible(locator);
                Common.Click(locator);
            }

            public class About
            {
                public static void ClickVotingProcedures2023()
                {
                    string locator = "//*[@id='header']//nav[not(contains(@class,'mobile'))]//*[contains(@title,'Voting Procedures 2023')]";
                    Common.WaitForElementToBeVisible(locator);
                    Common.Click(locator);
                }
            }
        }
    }
}
