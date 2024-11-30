namespace Simaira.Digital.Systems.IntegrationTests.Configuration
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public interface IConfigurationLoader
    {
        T LoadConfiguration<T>(string configFileName, TestContext context, bool useGlobalConfig = false);
    }
}
