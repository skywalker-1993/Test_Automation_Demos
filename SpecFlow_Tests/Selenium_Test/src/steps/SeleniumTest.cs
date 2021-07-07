using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System;
using Xunit;
using System.Diagnostics;

namespace selenium_test.src.steps
{
    [Binding]
    public class SeleniumTest
    {
        private readonly ScenarioContext _scenarioContext;

        //private FirefoxDriver driver = new FirefoxDriver();
        private FirefoxDriver driver;

        public SeleniumTest(ScenarioContext scenarioContext)
        {
            this._scenarioContext = scenarioContext;
            this.driver = createFirefoxDriver("en-US");
        }

        private static FirefoxDriver createFirefoxDriver(string locale)
        {
            // Does not work as expected...
            FirefoxOptions options = new FirefoxOptions();
            options.SetPreference("intl.accept_languages", locale);
            //options.AddArgument("--lang=de-DE");

            return new FirefoxDriver(options);
        }

        [Given(@"I am on the Google search page")]
        public void TestWithFirefoxDriver()
        {
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                driver.Navigate().GoToUrl(@"https://www.google.com");
                driver.Manage().Window.Maximize();
            }
        }

        [When(@"I click the 'I agree' button")]
        public void ClickIAgree()
        {
            {
                driver.SwitchTo().Frame(0);
                driver.FindElement(By.Id("introAgreeButton")).Click();
            }
        }

        [Then(@"I search for (.*)")]
        public void SearchSomething(string item)
        {
            {
                driver.SwitchTo().Window(driver.WindowHandles[0]);
                driver.FindElementByXPath("//input[@class=\"gLFyf gsfi\"]").SendKeys(item);
                driver.FindElementByXPath("//input[@class=\"gNO89b\"]").Click();
            }
        }

        [Then(@"I get the number of results")]
        public void GetNumberOfResults()
        {
            {
                string results = driver.FindElementByXPath("//div[@id=\"result-stats\"]").Text;
                // Console.WriteLine(results);
                // Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
                // Trace.WriteLine("Hello World");

                Assert.True(true, results); // If set to 'false' the results are shown in trx report
            }
        }

        [Then(@"I quit the browser")]
        public void QuitBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
