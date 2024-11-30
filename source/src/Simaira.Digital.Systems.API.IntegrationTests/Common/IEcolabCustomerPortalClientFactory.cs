namespace Simaira.Digital.Systems.IntegrationTests.Common
{
    using Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels;
    using System.Threading.Tasks;

    public interface IEcolabCustomerPortalClientFactory
    {
        Task<T> HttpPostAsync<T>(string url, RequestPayload requestPayload);
    }
}
