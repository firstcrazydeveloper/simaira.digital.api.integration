namespace Simaira.Digital.Systems.IntegrationTests.Common
{
    using Microsoft.Azure.Cosmos;
    using System.Diagnostics.CodeAnalysis;

    [ExcludeFromCodeCoverage]
    public class CosmosDbContainer : ICosmosDbContainer
    {
        public Container DbContainer { get; }

        public CosmosDbContainer(CosmosClient dbClient, string dbName, string containerName)
        {
            this.DbContainer = dbClient.GetContainer(dbName, containerName);
        }
    }
}
