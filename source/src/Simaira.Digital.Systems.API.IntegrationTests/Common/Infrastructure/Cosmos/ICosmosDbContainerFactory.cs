namespace Simaira.Digital.Systems.IntegrationTests.Common
{
    public interface ICosmosDbContainerFactory
    {
        ICosmosDbContainer GetContainer(string containerName);
    }
}
