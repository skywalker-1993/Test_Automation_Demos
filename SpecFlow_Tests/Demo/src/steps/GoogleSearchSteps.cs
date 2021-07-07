using TechTalk.SpecFlow;
using System;
using Xunit;

namespace Demo.src.steps
{
    [Binding]
    public class GoogleSearchSteps
    {
        [Given(@"I am on the Google search page")]
        public void GivenIAmOnTheGoogleSearchPage(){
            Console.WriteLine("I am on the Google search page");
        }
 
        [When(@"I search phrase (.*)")]
        public void WhenISearchPhrase(string phase){
            Console.WriteLine("When Some conditions");
        }
 
        [Then(@"results for (.*) are displayed")]
        public void ThenResultsForAreDisplayed(string phase){
            Console.WriteLine("Then some outcome");
            Assert.True(true,"expected true found true");
        }
    }
}