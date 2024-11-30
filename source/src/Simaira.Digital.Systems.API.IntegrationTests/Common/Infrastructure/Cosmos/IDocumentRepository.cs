namespace Simaira.Digital.Systems.IntegrationTests.Common
{
    using System.Threading.Tasks;
    public interface IDocumentRepository<T>
        where T : class
    {
        Task<bool> InsertDataAsync(T value, string partitionKeyValue);
    }
}
