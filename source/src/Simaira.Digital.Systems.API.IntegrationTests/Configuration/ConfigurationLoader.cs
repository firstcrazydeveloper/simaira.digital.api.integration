namespace Simaira.Digital.Systems.IntegrationTests.Configuration
{
    using Simaira.Digital.Systems.IntegrationTests.Common;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Newtonsoft.Json;
    using System;

    public class ConfigurationLoader : IConfigurationLoader
    {
        private readonly IFileClient _fileClient;

        public ConfigurationLoader(IFileClient fileClient)
        {
            _fileClient = fileClient;
        }

        public T LoadConfiguration<T>(string configFileName, TestContext context, bool useGlobalConfig = false)
        {
            try
            {
                var fullyQualifiedName = context.GetFullyQualifiedResourcePath(configFileName, useGlobalConfig);
                var configJson = _fileClient.LoadFromManifestResourceStream(fullyQualifiedName);
                return JsonConvert.DeserializeObject<T>(configJson);
            }
            catch(Exception ex)
            {
                throw;

            }
        }
    }
}
