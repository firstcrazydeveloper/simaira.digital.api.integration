namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class UserHierarchyRequest
    {
        [JsonProperty(PropertyName = "accountNumbers")]
        public IEnumerable<string> AccountNumbers { get; set; }

        [JsonProperty(PropertyName = "customerKey")]
        public int CustomerKey { get; set; }

        [JsonProperty(PropertyName = "siteKeys")]
        public IEnumerable<string> SiteKeys { get; set; }

        [JsonProperty(PropertyName = "graphNodeSiteKeys")]
        public IEnumerable<string> GraphNodeSiteKeys { get; set; }
    }
}
