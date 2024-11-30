namespace Simaira.Digital.Systems.IntegrationTests.Common
{
    using System.Threading.Tasks;

    public interface IBaseTokenHandler
    {
        Task<AccessToken> GetAccessTokenAsync(
            string applicationClientId,
            string clientSecret,
            string applicationTenantId,
            string authScope);

    }
}
