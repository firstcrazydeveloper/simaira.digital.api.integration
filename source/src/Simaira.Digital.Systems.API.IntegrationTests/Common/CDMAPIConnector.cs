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
        private const string CdmClientId = "";
        private const string CdmClientSecret = "";
        private const string CdmTenantId = "";
        private const string CdmClientSecretScope = "";

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
