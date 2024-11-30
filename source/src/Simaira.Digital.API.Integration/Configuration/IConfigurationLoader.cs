namespace Simaira.Digital.API.Integration.Configuration
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public interface IConfigurationLoader
    {
        T LoadConfiguration<T>(string configFileName, TestContext context, bool useGlobalConfig = false);
    }
}
