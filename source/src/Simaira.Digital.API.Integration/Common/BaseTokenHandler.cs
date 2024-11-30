using Microsoft.Identity.Client;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Simaira.Digital.API.Integration.Common
{

    public class BaseTokenHandler : IBaseTokenHandler
    {
        private static AccessToken? _accessToken;
        private static readonly SemaphoreSlim AccessTokenSemaphore;
        static BaseTokenHandler()
        {
            _accessToken = null!;
            AccessTokenSemaphore = new SemaphoreSlim(1, 1);
        }

        public BaseTokenHandler()
        {

        }

        public virtual async Task<AccessToken> GetAccessTokenAsync(
            string applicationClientId,
            string clientSecret,
            string applicationTenantId,
            string authScope)
        {
            if (_accessToken is { Expired: false })
            {
                return _accessToken;
            }

            _accessToken = await FetchTokenAsync(applicationClientId, clientSecret, applicationTenantId, authScope);
            return _accessToken;
        }

        private async Task<AccessToken> FetchTokenAsync(
            string applicationClientId,
            string clientSecret,
            string applicationTenantId,
            string authScope)
        {
            try
            {
                await AccessTokenSemaphore.WaitAsync();

                if (_accessToken is { Expired: false })
                {
                    return _accessToken;
                }
                IConfidentialClientApplication appAuth = ConfidentialClientApplicationBuilder.Create(applicationClientId)
               .WithClientSecret(clientSecret)
               .WithTenantId(applicationTenantId)
               .Build();
                string[] scopes = new[] { authScope };
                var result = await appAuth.AcquireTokenForClient(scopes).ExecuteAsync();

                var accessToken = new AccessToken(result.AccessToken, result.ExpiresOn.DateTime);
                return accessToken ?? throw new Exception("Failed to deserialize access token");


            }
            finally
            {
                AccessTokenSemaphore.Release(1);
            }
        }
    }
}
