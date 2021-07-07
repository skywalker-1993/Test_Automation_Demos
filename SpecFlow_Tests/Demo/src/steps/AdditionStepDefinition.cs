using TechTalk.SpecFlow;
using Xunit;

namespace Demo.src.steps
{
    [Binding]
    public sealed class AdditionStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private int num1 { get; set; }
        private int num2 { get; set; }

        public AdditionStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"I add (.*) and (.*)")]
        public void WhenTheTwoNumbersAreAdded(int number1, int number2)
        {
            num1 = number1;
            num2 = number2;
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            bool isEqual;
            if (num1 + num2 == result)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }
            Assert.True(isEqual);
        }
    }
}