using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SeleniumGoogleTest.com.configuration.browser;
using SeleniumGoogleTest.com.pages;

namespace SeleniumGoogleTest.com.tests;

public class BeforeWebConfiguration
{
    
    protected IWebDriver Driver;
    protected GoogleHomePage GoogleHomePage;

    [SetUp]
    public void Setup()
    {
        var browserConfig = new BrowserConfig();
        Driver = browserConfig.CreateDriver();
        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
        GoogleHomePage = new GoogleHomePage(Driver);
    }

    [TearDown]
    public void TearDown()
    {
        if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
        {
            MakeAScreenshot.TakeScreenshot(Driver, TestContext.CurrentContext.Test.Name);
        }
        Driver.Quit();
    }
}