using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simaira.Digital.API.Integration.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Simaira.Digital.API.Integration.Features.test.StepDefinitions
{
    [Binding]
    public class TestAPISteps : BaseSteps
    {
        public TestAPISteps(APIClientFactory apiClientFactory, ScenarioContext scenarioContext, Endpoints endpoints)
           : base(apiClientFactory, scenarioContext, endpoints)
        {
        }


        [Then(@"Get Publi API Response")]
        public async Task GetDishMachineOverallPerformanceAsync()
        {
            var result = await _apiClientFactory.HttpGetAsync<object>("https://cat-fact.herokuapp.com/facts/").ConfigureAwait(false);
            Assert.IsNotNull(result);
            AddToScenarioContext(ServiceAreasKey, result);
        }
    }
}
