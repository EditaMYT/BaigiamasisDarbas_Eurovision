using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework
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
    }
}
