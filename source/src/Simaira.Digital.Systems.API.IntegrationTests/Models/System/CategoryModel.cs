namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;

    public class CategoryModel
    {
        [JsonProperty(PropertyName = "SegmentInfo[BrandStandards_Category]")]
        public string BrandStandardCategory { get; set; }

        [JsonProperty(PropertyName = "[Flag_Catogeries]")]
        public int IsGoodstanding { get; set; }

        [JsonProperty(PropertyName = "dimAccount[CdmSite]")]
        public string CdmSite { get; set; }

        [JsonProperty(PropertyName = "dimAccount[GraphNodeSiteKey]")]
        public string GraphNodeSiteKey { get; set; }

        [JsonProperty(PropertyName = "dimBSinsights[Segment]")]
        public string SegmentType { get; set; }
    }
}