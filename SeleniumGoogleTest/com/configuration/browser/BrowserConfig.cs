using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumGoogleTest.com.configuration.browser
{
    public class BrowserConfig
    {
        public IWebDriver CreateDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--disable-blink-features=AutomationControlled");

            if (Environment.GetEnvironmentVariable("DRIVER") == "REMOTE")
            {
                options.AddArguments("--headless");
                //To avoid the CAPTCHA using headless mode
                options.AddArgument("--user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36");

            }
            return new ChromeDriver(options);
        }
    }
}