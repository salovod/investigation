using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumGoogleTest.com.configuration.logger;

namespace SeleniumGoogleTest.com.tests
{
    public class GoogleTest : BeforeWebConfiguration
    {
        private const string BaseUrl = "https://www.google.com/";

        [Test]
        public void GoogleSearchTutorialTest()
        {
            Logger.Step("1... Open Google page");
                Driver.Navigate().GoToUrl(BaseUrl);
                Assert.That(GoogleHomePage.SearchInputField.Displayed, Is.True, 
                    "Search input field isn't presented");
                /*
                 I really hate boolean verifications, but due to lack of the knowledge
                 cannot check something similar to (googleHomePage.SearchInputField, Is.Presented)
                */
            
            Logger.Step("2... Search for 'Selenium C# tutorial' and press 'Enter' keyboard button");
                GoogleHomePage.SearchInputField.SendKeys("Selenium C# tutorial" + Keys.Enter);
                Assert.That(GoogleHomePage.SearchResult.Displayed, Is.True, "Result not found");
                Assert.That(GoogleHomePage.ListOfResults.Count, Is.GreaterThan(0),
                    "No results found");
                
            Logger.Step("3... Check that first result contains 'Selenium'");
                var firstElementInTheResult = GoogleHomePage.ListOfResults.First().Text;
                Assert.That(firstElementInTheResult.Contains("Selenium"),
                    """
                    First search results doesn't contain 'Selenium'.
                    Actual results is {firstElementInTheResult}
                    """);
        }
    }
}