namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;


    public class OptimalProduct
    {
        [JsonProperty(PropertyName = "[NotPurchased_Categories]")]
        public string NotPurchased { get; set; }

        [JsonProperty(PropertyName = "[Total_Categories_Count]")]
        public string TotalCategories { get; set; }

        [JsonProperty(PropertyName = "dimAccount[CdmSite]")]
        public string CdmSite { get; set; }

        [JsonProperty(PropertyName = "dimAccount[GraphNodeSiteKey]")]
        public string GraphNodeSiteKey { get; set; }

        [JsonProperty(PropertyName = "dimBSinsights[Segment]")]
        public string SegmentType { get; set; }
    }
}