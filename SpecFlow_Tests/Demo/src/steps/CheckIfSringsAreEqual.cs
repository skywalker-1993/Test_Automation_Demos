using TechTalk.SpecFlow;
using Xunit;

namespace Demo.src.steps
{
    [Binding]
    public sealed class CheckIfStringsAreEqual
    {
        private readonly ScenarioContext _scenarioContext;
        private string string1 { get; set; }
        private string string2 { get; set; }

        public CheckIfStringsAreEqual(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"I enter strings (.*) and (.*)")]
        public void WhenTheTwoStringsAreSet(string str1, string str2)
        {
            string1 = str1;
            string2 = str2;
        }

        [Then(@"they should be equal")]
        public void ThenTheyShoudBeEqual()
        {
            Assert.True(string.Equals(string1, string2));
        }
    }
}