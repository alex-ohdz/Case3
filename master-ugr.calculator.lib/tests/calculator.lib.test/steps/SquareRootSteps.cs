using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace calculator.lib.test.steps
{
    [Binding]
    public class SquareRootSteps
    {
        private readonly ScenarioContext _scenarioContext;
        public SquareRootSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"a number to calculate square root (.*)")]
        public void GivenANumberToCalculateSquareRoot(int number)
        {
            _scenarioContext.Add("number", number);
        }

        [When("I calculate the square root")]
        public void ICalculateTheSquareRoot()
        {
            var number = _scenarioContext.Get<int>("number");
            var squareRoot = NumberAttributter.SquareRoot(number);
            _scenarioContext.Add("squareRoot", squareRoot);
        }
        [Then("the square root should be (.*)")]
        public void TheSquareRootShouldBe(double expected)
        {
            var squareRoot = _scenarioContext.Get<double>("squareRoot");
            Assert.Equal(expected, squareRoot);
        }
    }
}