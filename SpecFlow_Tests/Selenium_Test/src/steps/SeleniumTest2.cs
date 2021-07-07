using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System;

namespace selenium_test.src.steps
{
    [Binding]
    public class SeleniumTest2
    {
        private readonly ScenarioContext _scenarioContext;
        private FirefoxDriver driver = new FirefoxDriver();

        public SeleniumTest2(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I am on the Amazon search page")]
        public void TestWithFirefoxDriver()
        {
            {
                driver.Navigate().GoToUrl(@"https://www.amazon.com");
                driver.Manage().Window.Maximize();
            }
        }

        [Then(@"I quit the browser again")]
        public void QuitBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
