namespace Simaira.Digital.API.Integration.TestsResponse
{
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;

    public class APIConfig
    {
        [Required]
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        [Required]
        [JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret { get; set; }

        [Required]
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

        [Required]
        [JsonProperty(PropertyName = "clientSecretScope")]
        public string ClientSecretScope { get; set; }

        [Required]
        [JsonProperty(PropertyName = "appInsightInstrumentationKey")]
        public string AppInsightInstrumentationKey { get; set; }

        [Required]
        [JsonProperty(PropertyName = "cosmosEndpoint")]
        public string CosmosEndpoint { get; set; }
    }
}
