using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumGoogleTest.com.configuration.browser;

public class BrowserConfig
{
    public IWebDriver CreateDriver()
    {
        var options = new ChromeOptions();
        options.AddArgument("--disable-blink-features=AutomationControlled");
        return new ChromeDriver(options);
    }
}