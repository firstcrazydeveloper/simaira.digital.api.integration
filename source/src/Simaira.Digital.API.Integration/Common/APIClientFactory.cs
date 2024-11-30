using EnsureThat;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Simaira.Digital.API.Integration.Configuration;
using Simaira.Digital.API.Integration.TestsResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Simaira.Digital.API.Integration.Common
{
    public class APIClientFactory : BaseTokenHandler, IAPIClientFactory
    {
        private readonly HttpClient _httpClient;
        private readonly IConfigurationLoader _configurationLoader;
        private readonly TestContext _testContext;
        private const string CustomerPortalConfig = "customerPortalConfig.json";
        private const string MediaFormatter = "application/json";


        public APIClientFactory(HttpClient httpClient, IConfigurationLoader configurationLoader, TestContext testContext)
        {
            _httpClient = httpClient;
            _configurationLoader = configurationLoader;
            _testContext = testContext;
        }

        public async Task<T> HttpPostAsync<T>(string url, JObject requestPayload)
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
            catch (Exception ex)
            {
                throw;
            }

            return default;
        }

        public async Task<T> HttpGetAsync<T>(string url)
        {
            EnsureArg.IsNotNull(url, nameof(url));

            try
            {
                //await SetTokenHeaderAsync();
                var response = await _httpClient.GetAsync(url).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    var responseObject = JsonConvert.DeserializeObject<T>(responseString);
                    return responseObject;
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return default;
        }



        private async Task SetTokenHeaderAsync()
        {
            var customerPortalConfig = _configurationLoader.LoadConfiguration<APIConfig>(CustomerPortalConfig, _testContext);
            var accessToken = await GetAccessTokenAsync(customerPortalConfig.ClientId,
                customerPortalConfig.ClientSecret,
                customerPortalConfig.TenantId,
                customerPortalConfig.ClientSecretScope);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaFormatter));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken.Token);
        }
    }
}
