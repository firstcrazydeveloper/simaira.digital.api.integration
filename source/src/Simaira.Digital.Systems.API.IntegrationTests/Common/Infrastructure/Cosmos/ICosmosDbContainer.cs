namespace Simaira.Digital.Systems.IntegrationTests.Common
{
    using Microsoft.Azure.Cosmos;
    public interface ICosmosDbContainer
    {
        Container DbContainer { get; }
    }
}
