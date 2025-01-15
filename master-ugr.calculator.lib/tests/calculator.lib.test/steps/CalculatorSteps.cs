using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace calculator.lib.test.steps
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public CalculatorSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int firstNumber)
        {
            _scenarioContext.Add("firstNumber", firstNumber);
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int secondNumber)
        {
            _scenarioContext.Add("secondNumber", secondNumber);
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            var firstNumber = _scenarioContext.Get<int>("firstNumber");
            var secondNumber = _scenarioContext.Get<int>("secondNumber");
            var result = Calculator.Add(firstNumber, secondNumber);
            _scenarioContext.Add("result", (double)result);
        }
        //[When(@"I divide first number by second number")]
        //public void WhenIDivideFirstNumberBySecondNumber()
        //{
        //    var firstNumber = _scenarioContext.Get<int>("firstNumber");
        //    var secondNumber = _scenarioContext.Get<int>("secondNumber");

        //    double result;
        //    if (secondNumber == 0)
        //    {
        //        result = double.NaN; // Manejo explícito para división por cero
        //    }
        //    else
        //    {
        //        result = Calculator.Divide(firstNumber, secondNumber);
        //    }

        //    _scenarioContext.Add("result", result);
        //}

        //[When(@"I divide both numbers")]
        //public void WhenIDivideBothNumbers()
        //{
        //    var firstNumber = _scenarioContext.Get<int>("firstNumber");
        //    var secondNumber = _scenarioContext.Get<int>("secondNumber");

        //    double result;

        //    if (secondNumber == 0)
        //    {
        //        result = double.NaN; // Manejo explícito de la división por cero
        //    }
        //    else
        //    {
        //        result = Calculator.Divide(firstNumber, secondNumber);
        //    }

        //    _scenarioContext.Add("result", result);
        //}
        [When(@"I divide the numbers")]
        public void WhenIDivideTheNumbers()
        {
            var firstNumber = _scenarioContext.Get<int>("firstNumber");
            var secondNumber = _scenarioContext.Get<int>("secondNumber");

            double result = secondNumber == 0 ? double.NaN : Calculator.Divide(firstNumber, secondNumber);

            _scenarioContext.Add("result", result);
        }


        [When(@"I divide first number by second number")]
        public void WhenIDivideFirstNumberBySecondNumber()
        {
            var firstNumber = _scenarioContext.Get<int>("firstNumber");
            var secondNumber = _scenarioContext.Get<int>("secondNumber");

            double result = secondNumber == 0 ? double.NaN : Calculator.Divide(firstNumber, secondNumber);
            _scenarioContext.Add("result", result);
        }



        [When(@"I multiply both numbers")]
        public void WhenIMultiplyBothNumbers()
        {
            var firstNumber = _scenarioContext.Get<int>("firstNumber");
            var secondNumber = _scenarioContext.Get<int>("secondNumber");
            var result = (double)Calculator.Multiply(firstNumber, secondNumber);
            _scenarioContext.Add("result", result);
        }

        [When(@"I substract first number to second number")]
        public void WhenISubstractFirstNumberToSecondNumber()
        {
            var firstNumber = _scenarioContext.Get<int>("firstNumber");
            var secondNumber = _scenarioContext.Get<int>("secondNumber");
            var result = (double)Calculator.Subtract(firstNumber, secondNumber);
            _scenarioContext.Add("result", result);
        }

        [Then(@"the result should be (.*)")]
        [Then(@"the result shall be (.*)")]
        [Then(@"the result is (.*)")]
        public void ThenTheResultShouldBe(double expectedResult)
        {
            var result = _scenarioContext.Get<double>("result");
            Assert.Equal(result, expectedResult);
        }

        [Then(@"the result shall be exactly NaN")]
        public void ThenTheResultShallBeNaN()
        {
            var result = _scenarioContext.Get<double>("result");
            Assert.True(double.IsNaN(result), "Expected the result to be NaN.");
        }


    }
}
