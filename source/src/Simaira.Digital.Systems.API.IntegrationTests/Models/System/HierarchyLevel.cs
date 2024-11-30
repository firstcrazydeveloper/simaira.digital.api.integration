namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;

    public class HierarchyLevel
    {
        [JsonProperty(PropertyName = "dimAccount[CdmSite]")]
        public string CdmSite { get; set; }

        [JsonProperty(PropertyName = "dimAccount[GraphNodeSiteKey]")]
        public string GraphNodeSiteKey { get; set; }

        [JsonProperty(PropertyName = "dimAccount[HL1]")]
        public string HierarchyLevel1 { get; set; }

        [JsonProperty(PropertyName = "dimAccount[HL2]")]
        public string HierarchyLevel2 { get; set; }

        [JsonProperty(PropertyName = "dimAccount[HL3]")]
        public string HierarchyLevel3 { get; set; }

        [JsonProperty(PropertyName = "dimAccount[HL4]")]
        public string HierarchyLevel4 { get; set; }

        [JsonProperty(PropertyName = "dimAccount[HL5]")]
        public string HierarchyLevel5 { get; set; }

        [JsonProperty(PropertyName = "dimAccount[HL6]")]
        public string HierarchyLevel6 { get; set; }

        [JsonProperty(PropertyName = "dimAccount[HL7]")]
        public string HierarchyLevel7 { get; set; }

        [JsonProperty(PropertyName = "dimAccount[HL8]")]
        public string HierarchyLevel8 { get; set; }

        [JsonProperty(PropertyName = "dimAccount[HL9]")]
        public string HierarchyLevel9 { get; set; }

        [JsonProperty(PropertyName = "dimAccount[HL10]")]
        public string HierarchyLevel10 { get; set; }
    }
}