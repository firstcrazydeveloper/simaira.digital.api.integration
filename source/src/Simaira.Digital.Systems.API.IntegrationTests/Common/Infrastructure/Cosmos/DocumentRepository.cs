namespace Simaira.Digital.Systems.IntegrationTests.Common
{
    using EnsureThat;
    using Microsoft.Azure.Cosmos;
    using System;
    using System.Threading.Tasks;
    using PartitionKey = Microsoft.Azure.Cosmos.PartitionKey;

    public class DocumentRepository<T> : IDocumentRepository<T>
        where T : class
    {
        private readonly ICosmosDbContainerFactory _cosmosDbContainerFactory;
        private readonly Container _container;

        public DocumentRepository(ICosmosDbContainerFactory cosmosDbContainerFactory)
        {
            _cosmosDbContainerFactory = cosmosDbContainerFactory;
            _container = _cosmosDbContainerFactory.GetContainer("APIIntegrationTest").DbContainer;
        }

        public async Task<bool> InsertDataAsync(T value, string partitionKeyValue)
        {
            EnsureArg.IsNotNull(value, nameof(value));
            EnsureArg.IsNotNull(partitionKeyValue, nameof(partitionKeyValue));
            try
            {
                var response = await _container.UpsertItemAsync(value);
                return response.StatusCode == System.Net.HttpStatusCode.OK ? true : false;
            }
            catch(Exception ex)
            {
                throw;
            }
            
        }

    }
}
