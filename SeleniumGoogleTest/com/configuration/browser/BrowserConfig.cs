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
            options.AddArguments("--headless");
            // options.AddArguments("--disable-dev-shm-usage");
            // options.AddArguments("--no-sandbox");
            // var userDataDir = Path.Combine(Path.GetTempPath(), "ChromeUserData", $"{Guid.NewGuid()}_{DateTime.Now.Ticks}");
            // options.AddArguments($"--user-data-dir={userDataDir}");

            return new ChromeDriver(options);
        }
    }
}