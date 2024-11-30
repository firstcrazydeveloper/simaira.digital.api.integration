namespace Simaira.Digital.Systems.IntegrationTests.Common
{
    using Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels;
    using Simaira.Digital.Systems.IntegrationTests.Configuration;
    using Simaira.Digital.Systems.IntegrationTests.Models.TestsResponse;
    using EnsureThat;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Newtonsoft.Json;
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    public class EcolabCustomerPortalClientFactory : BaseTokenHandler, IEcolabCustomerPortalClientFactory
    {
        private readonly HttpClient _httpClient;
        private readonly IConfigurationLoader _configurationLoader;
        private readonly TestContext _testContext;
        private const string CustomerPortalConfig = "customerPortalConfig.json";
        private const string MediaFormatter = "application/json";


        public EcolabCustomerPortalClientFactory(HttpClient httpClient, IConfigurationLoader configurationLoader, TestContext testContext)
        {
            _httpClient = httpClient;
            _configurationLoader = configurationLoader;
            _testContext = testContext;
        }

        public async Task<T> HttpPostAsync<T>(string url, RequestPayload requestPayload)
        {
            EnsureArg.IsNotNull(url, nameof(url));

            var requestBody = JsonConvert.SerializeObject(requestPayload);
            var stringContent = new StringContent(requestBody, UnicodeEncoding.UTF8, "application/json");

            try
            {
                await SetTokenHeaderAsync();
                var response = await _httpClient.PostAsync(url, stringContent).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    var responseObject = JsonConvert.DeserializeObject<T>(responseString);
                    return responseObject;
                }
            }
            catch(Exception ex)
            {
                throw;
            }

            return default;
        }


        private async Task SetTokenHeaderAsync()
        {
            var customerPortalConfig = _configurationLoader.LoadConfiguration<CustomerPortalConfig>(CustomerPortalConfig, _testContext);
            var accessToken = await GetAccessTokenAsync(customerPortalConfig.CustomerPortalClientId,
                customerPortalConfig.CustomerPortalClientSecret,
                customerPortalConfig.CustomerPortalTenantId,
                customerPortalConfig.CustomerPortalClientSecretScope);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaFormatter));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken.Token);
        }

    }
}
