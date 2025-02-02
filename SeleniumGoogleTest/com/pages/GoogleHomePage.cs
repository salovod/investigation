using System.Collections.Generic;
using OpenQA.Selenium;

namespace SeleniumGoogleTest.com.pages;

public class GoogleHomePage(IWebDriver driver)
{
    public IWebElement SearchInputField => driver.FindElement(By.XPath("//*[@name='q']"));
    
    public IWebElement SearchResult => driver.FindElement(By.XPath("//*[@id='rso']"));
    
    public IReadOnlyCollection<IWebElement> ListOfResults => driver.FindElements(By.XPath("//*[@id='rso']//h3"));
}