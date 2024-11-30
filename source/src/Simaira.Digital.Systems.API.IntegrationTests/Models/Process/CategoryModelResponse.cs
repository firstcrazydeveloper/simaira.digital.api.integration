namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Process
{
    using Newtonsoft.Json;

    public class CategoryModelResponse
    {
        [JsonProperty(PropertyName = "brandStandardCategory")]
        public string BrandStandardCategory { get; set; }

        [JsonProperty(PropertyName = "isGoodstanding")]
        public int IsGoodstanding { get; set; }

        [JsonProperty(PropertyName = "cdmSite")]
        public string CdmSite { get; set; }

        [JsonProperty(PropertyName = "graphNodeSiteKey")]
        public string GraphNodeSiteKey { get; set; }

        [JsonProperty(PropertyName = "segmentType")]
        public string SegmentType { get; set; }
    }
}