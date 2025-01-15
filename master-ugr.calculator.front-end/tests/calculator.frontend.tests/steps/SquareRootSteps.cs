using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace calculator.frontend.tests.steps
{
    [Binding]
    public class SquareRootSteps
    {
        private readonly ScenarioContext _scenarioContext;
        public SquareRootSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [When(@"the square root of (.*) is requested")]
        public async Task WhenTheSquareRootOfIsRequested(int number)
        {
            IPage page = _scenarioContext.Get<IPage>("page");
            var base_url = _scenarioContext.Get<string>("urlBase");
            await page.GotoAsync($"{base_url}/Calculator");
            await page.FillAsync("#number", number.ToString());
            await page.ClickAsync("#squareRoot");
        }
        [Then(@"the square root is (.*)")]
        public async Task ThenTheSquareRootIs(string squareRoot)
        {
            var page = (IPage)_scenarioContext["page"];
            var resultText = await page.InnerTextAsync("#result");
            Assert.Equal(squareRoot, resultText);
        }