namespace Simaira.Digital.Systems.IntegrationTests.Common.StepDefinitions
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Simaira.Digital.Systems.IntegrationTests.Configuration;
    using Simaira.Digital.Systems.IntegrationTests.Models.TestsResponse;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Newtonsoft.Json;
    using TechTalk.SpecFlow;

    [Binding]
    public class ContextLogger
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly FeatureContext _featureContext;
        private readonly TestContext _testContext;
        private readonly TestContextResultFileWriter _testContextResultFileWriter;
        private readonly IDocumentRepository<ScenarioTest> _documentRepository;
        private readonly ITelemetryClientService<ScenarioTest> _telemetryClientService;

        public ContextLogger(ScenarioContext scenarioContext, FeatureContext featureContext, TestContext testContext, TestContextResultFileWriter testContextResultFileWriter, IDocumentRepository<ScenarioTest> documentRepository, ITelemetryClientService<ScenarioTest> telemetryClientService)
        {
            _scenarioContext = scenarioContext;
            _featureContext = featureContext;
            _testContext = testContext;
            _testContextResultFileWriter = testContextResultFileWriter;
            _documentRepository = documentRepository;
            _telemetryClientService = telemetryClientService;
        }

        [AfterScenario(Order = int.MaxValue)]
        public async Task AfterScenario()
        {
            Exception lastError = _scenarioContext.TestError;

            ScenarioTest test = new ScenarioTest();
            if (lastError != null)
            {
                LogContexts();                
            }

           
            test.TestClass = _testContext.FullyQualifiedTestClassName;
            test.FeatureTitle = Convert.ToString(_testContext.Properties["FeatureTitle"]);
            test.TestName = _testContext.TestName;
            test.Status = _testContext.CurrentTestOutcome.ToString();
            test.TimeStamp = DateTime.Now.ToString();
            test.Id = Guid.NewGuid().ToString();
            test.Environment = _testContext.GetEnvironment().ToLower();
            test.LogContexts.Add("Feature", JsonConvert.SerializeObject(_featureContext));
            test.LogContexts.Add("Scenario", JsonConvert.SerializeObject(_scenarioContext));

            try
            {
                var jsonString = JsonConvert.SerializeObject(test);
                if (jsonString.Length >= 32000)
                {
                    test.IsScenarioContextStoreInCosmos = true;
                    await _documentRepository.InsertDataAsync(test, test.Status).ConfigureAwait(false);
                    test.LogContexts = new Dictionary<string, string>();
                }
                
                _telemetryClientService.LogTrace(JsonConvert.SerializeObject(test));
            }
            catch(Exception ex)
            {

            }
        }

        public void LogContexts()
        {
            LogContext(_scenarioContext, "Scenario");
            LogContext(_featureContext, "Feature");
        }

        private void LogContext(object content, string title)
        {
            var dataAsJson = JsonConvert.SerializeObject(content, Formatting.Indented);
            _testContextResultFileWriter.WriteAllText(title, "json", dataAsJson);
            _testContext.WriteLine(string.Format("Context output ({0}):", title));
            _testContext.WriteLine(dataAsJson);
        }
    }
}
