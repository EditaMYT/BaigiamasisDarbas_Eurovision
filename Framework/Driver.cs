using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.IO;

namespace Framework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
        }

        internal static IWebDriver GetDriver()
        {
            return driver;
        }

        internal static void OpenPage(string url)
        {
            driver.Url = url;
        }

        public static void ShutdownDriver()
        {
            //driver.Quit();
        }

        public static string TakeScreenshot(string methodName)
        {
            string screenshotDirctoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}Screenshots";
            string screenshotName = $"{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}-{methodName}.png";
            string screenshotFilePath = $"{screenshotDirctoryPath}\\{screenshotName}";

            Directory.CreateDirectory(screenshotDirctoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile($"{screenshotFilePath}", ScreenshotImageFormat.Png);

            return screenshotFilePath;
        }
    }
}

