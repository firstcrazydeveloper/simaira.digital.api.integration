namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using Newtonsoft.Json;

    public class ServiceArea
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }

        [JsonProperty(PropertyName = "accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty(PropertyName = "cdmSiteKey")]
        public int CdmSiteKey { get; set; }

        [JsonProperty(PropertyName = "customerKey")]
        public int CustomerKey { get; set; }
    }
}
