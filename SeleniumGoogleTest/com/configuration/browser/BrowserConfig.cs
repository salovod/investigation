using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumGoogleTest.com.configuration.browser;

public class BrowserConfig
{
    public IWebDriver CreateDriver()
    {
        var options = new ChromeOptions();
        options.AddArgument("--disable-blink-features=AutomationControlled");
        var userDataDir = Path.Combine(Path.GetTempPath(), "ChromeUserData", Guid.NewGuid().ToString());
        options.AddArguments($"--user-data-dir={userDataDir}");
        return new ChromeDriver(options);
    }
}