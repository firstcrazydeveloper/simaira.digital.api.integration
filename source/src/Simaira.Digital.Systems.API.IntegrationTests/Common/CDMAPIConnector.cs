namespace Simaira.Digital.Systems.IntegrationTests.Common
{
    using EnsureThat;
    using Newtonsoft.Json;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    public class CDMAPIConnector : BaseTokenHandler, ICDMAPIConnector
    {
        private readonly HttpClient _httpClient;
        private const string CdmClientId = "f05de03f-61da-4095-927c-b069737f045c";
        private const string CdmClientSecret = "46z7Q~926cDzueRAquFvTD2IkGM1OJmQO8S5J";
        private const string CdmTenantId = "c1eb5112-7946-4c9d-bc57-40040cfe3a91";
        private const string CdmClientSecretScope = "api://761efe8d-1b2b-4ead-8414-fd5c3a2d7ae2/.default";

        public CDMAPIConnector(HttpClient httpClient)
            : base()
        {
            _httpClient = httpClient;
        }

        public async Task<T> CDMGetAsync<T>(string url)
        {
            EnsureArg.IsNotNull(url, nameof(url));
            try
            {
                await SetTokenHeaderAsync();
                var response = await _httpClient.GetAsync(url).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    var responseObject = JsonConvert.DeserializeObject<T>(responseString);
                    return responseObject;
                }
            }
            catch
            {
                throw;
            }

            return default;
        }

        private async Task SetTokenHeaderAsync()
        {
            var accessToken = await GetAccessTokenAsync(CdmClientId, CdmClientSecret, CdmTenantId, CdmClientSecretScope);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken.Token);
        }
    }
}
