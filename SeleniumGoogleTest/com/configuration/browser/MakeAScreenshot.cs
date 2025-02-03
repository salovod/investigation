using System;
using System.IO;
using OpenQA.Selenium;

namespace SeleniumGoogleTest.com.configuration.browser;

public static class MakeAScreenshot
{
    public static void TakeScreenshot(IWebDriver driver, string testName)
    {
        try
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            var screenshotsDir = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
            Directory.CreateDirectory(screenshotsDir);

            var screenshotFile = Path.Combine(screenshotsDir, $"{testName}_{DateTime.Now:yyyyMMdd_HHmmss}.png");
            screenshot.SaveAsFile(screenshotFile);

            Console.WriteLine($"Screenshot saved: {screenshotFile}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error capturing screenshot: {ex.Message}");
        }
    }
}