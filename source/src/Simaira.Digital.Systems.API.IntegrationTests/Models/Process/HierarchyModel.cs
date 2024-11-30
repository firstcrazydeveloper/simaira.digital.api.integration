namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Process
{
    using Newtonsoft.Json;

    public class HierarchyModel
    {
        [JsonProperty(PropertyName = "graphNodeSiteKey")]
        public string GraphNodeSiteKey { get; set; }

        [JsonProperty(PropertyName = "cdmSite")]
        public string CdmSite { get; set; }

        [JsonProperty(PropertyName = "hierarchyLevel1")]
        public string HierarchyLevel1 { get; set; }

        [JsonProperty(PropertyName = "hierarchyLevel2")]
        public string HierarchyLevel2 { get; set; }

        [JsonProperty(PropertyName = "hierarchyLevel3")]
        public string HierarchyLevel3 { get; set; }

        [JsonProperty(PropertyName = "hierarchyLevel4")]
        public string HierarchyLevel4 { get; set; }

        [JsonProperty(PropertyName = "hierarchyLevel5")]
        public string HierarchyLevel5 { get; set; }

        [JsonProperty(PropertyName = "hierarchyLevel6")]
        public string HierarchyLevel6 { get; set; }

        [JsonProperty(PropertyName = "hierarchyLevel7")]
        public string HierarchyLevel7 { get; set; }

        [JsonProperty(PropertyName = "hierarchyLevel8")]
        public string HierarchyLevel8 { get; set; }

        [JsonProperty(PropertyName = "hierarchyLevel9")]
        public string HierarchyLevel9 { get; set; }

        [JsonProperty(PropertyName = "hierarchyLevel10")]
        public string HierarchyLevel10 { get; set; }
    }
}
