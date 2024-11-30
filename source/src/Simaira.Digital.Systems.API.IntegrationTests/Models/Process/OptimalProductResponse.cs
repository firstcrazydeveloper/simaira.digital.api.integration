namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Process
{
    using Newtonsoft.Json;

    public class OptimalProductResponse
    {
        [JsonProperty(PropertyName = "notPurchased")]
        public int NotPurchased { get; set; }

        [JsonProperty(PropertyName = "totalCategories")]
        public int TotalCategories { get; set; }

        [JsonProperty(PropertyName = "cdmSite")]
        public string CdmSite { get; set; }

        [JsonProperty(PropertyName = "graphNodeSiteKey")]
        public string GraphNodeSiteKey { get; set; }
    }
}