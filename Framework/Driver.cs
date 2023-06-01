using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace Framework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void InitializeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--user-data-dir=C:\\Users\\Edita\\AppData\\Local\\Google\\Chrome\\User Data");
            options.AddArgument("--profile-directory=Profile 1");
            driver = new ChromeDriver(options);
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
            driver.Quit();
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

