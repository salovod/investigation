using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumGoogleTest.com.configuration.browser;
using SeleniumGoogleTest.com.configuration.logger;
using SeleniumGoogleTest.com.pages;

namespace SeleniumGoogleTest.com.tests
{
    public class GoogleTest
    {
        private IWebDriver _driver;
        private GoogleHomePage _googleHomePage;
        private const string BaseUrl = "https://www.google.com/";

        [SetUp]
        public void Setup()
        {
            var browserConfig = new BrowserConfig();
            _driver = browserConfig.CreateDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            _googleHomePage = new GoogleHomePage(_driver);
        }

        [Test]
        public void GoogleSearchTutorialTest()
        {
            Logger.Step("1... Open Google page");
                _driver.Navigate().GoToUrl(BaseUrl);
                Assert.That(_googleHomePage.SearchInputField.Displayed, Is.True, 
                    "Search input field isn't presented");
                /*
                 I really hate boolean verifications, but due to lack of the knowledge
                 cannot check something similar to (googleHomePage.SearchInputField, Is.Presented)
                */
            
            Logger.Step("2... Search for 'Selenium C# tutorial' and press 'Enter' keyboard button");
                _googleHomePage.SearchInputField.SendKeys("Selenium C# tutorial" + Keys.Enter);
                Assert.That(_googleHomePage.SearchResult.Displayed, Is.True, "Result not found");
                Assert.That(_googleHomePage.ListOfResults.Count, Is.GreaterThan(0),
                    "No results found");
                
            Logger.Step("3... Check that first result contains 'Selenium'");
                var firstElementInTheResult = _googleHomePage.ListOfResults.First().Text;
                Assert.That(firstElementInTheResult.Contains("Selenium"),
                    """
                    First search results doesn't contain 'Selenium'.
                    Actual results is {firstElementInTheResult}
                    """);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}