namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;
    public class SiteLocationDetailsRequest
    {
        [JsonProperty(PropertyName = "accountNumbers")]
        public IEnumerable<string> SiteKeys { get; set; }

        [JsonProperty(PropertyName = "graphNodeSiteKeys")]
        public IEnumerable<string> GraphNodeSiteKeys { get; set; }
    }
}
