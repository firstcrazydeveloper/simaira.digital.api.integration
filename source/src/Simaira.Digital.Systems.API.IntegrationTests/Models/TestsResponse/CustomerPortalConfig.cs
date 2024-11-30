namespace Simaira.Digital.Systems.IntegrationTests.Models.TestsResponse
{
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;

    public class CustomerPortalConfig
    {
        [Required]
        [JsonProperty(PropertyName = "customerPortalClientId")]
        public string CustomerPortalClientId { get; set; }

        [Required]
        [JsonProperty(PropertyName = "customerPortalClientSecret")]
        public string CustomerPortalClientSecret { get; set; }

        [Required]
        [JsonProperty(PropertyName = "customerPortalTenantId")]
        public string CustomerPortalTenantId { get; set; }

        [Required]
        [JsonProperty(PropertyName = "customerPortalClientSecretScope")]
        public string CustomerPortalClientSecretScope { get; set; }

        [Required]
        [JsonProperty(PropertyName = "appInsightInstrumentationKey")]
        public string AppInsightInstrumentationKey { get; set; }

        [Required]
        [JsonProperty(PropertyName = "cosmosEndpoint")]
        public string CosmosEndpoint { get; set; }
    }
}
