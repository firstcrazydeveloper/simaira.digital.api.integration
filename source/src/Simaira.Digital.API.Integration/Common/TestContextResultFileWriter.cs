namespace Simaira.Digital.API.Integration.Common
{
    using System;
    using System.IO;
    using System.Reflection;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TechTalk.SpecFlow;

    public class TestContextResultFileWriter
    {
        private const string TempPathPart = "TempContextFiles";
        private readonly ScenarioContext _scenarioContext;
        private readonly string _tempPath;
        private readonly TestContext _testContext;

        public TestContextResultFileWriter(ScenarioContext scenarioContext, TestContext testContext)
        {
            _scenarioContext = scenarioContext;
            _testContext = testContext;
            _tempPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), TempPathPart);
            Directory.CreateDirectory(_tempPath);
        }

        public void WriteAllText(string title, string extension, string content)
        {
            var fileNameFirstPart = _scenarioContext.ScenarioInfo.Title;
            if (fileNameFirstPart.Length > 100)
            {
                fileNameFirstPart = Guid.NewGuid().ToString();
            }

            var fileName = Path.Combine(_tempPath, string.Format("{0}_{1}.{2}", fileNameFirstPart, title, extension));
            File.WriteAllText(fileName, content);
            _testContext.AddResultFile(fileName);
        }
    }
}
