using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit;

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

        [Given(@"the number is (.*)")]
        public void GivenTheNumberIs(double number)
        {
            // Almacena el número en el contexto del escenario
            _scenarioContext["number"] = number;
        }

        [When(@"I calculate its square root")]
        public void WhenICalculateTheSquareRoot()
        {
            // Recupera el número del contexto y calcula la raíz cuadrada usando SqrtNumber
            var number = (double)_scenarioContext["number"];
            var result = Calculator.SqrtNumber(number);
            _scenarioContext["result"] = result;
        }

        [Then(@"the square root should be (.*)")]
        public void ThenTheSquareRootShouldBe(double expectedResult)
        {
            // Recupera el resultado del contexto y lo compara con el valor esperado
            var result = (double)_scenarioContext["result"];
            Assert.Equal(expectedResult, result, precision: 4); // Comparación con tolerancia de precisión
        }
    }
}