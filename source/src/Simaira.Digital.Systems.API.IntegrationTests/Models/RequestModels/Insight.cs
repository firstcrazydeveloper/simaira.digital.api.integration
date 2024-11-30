namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using global::System.Collections.Generic;
    using global::System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    public class Insight
    {
        [Required]
        [JsonProperty(PropertyName = "days")]
        public int Days { get; set; }

        [Required]
        [JsonProperty(PropertyName = "types")]
        public IEnumerable<string> Types { get; set; }

        [Required]
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        [JsonProperty(PropertyName = "siteKeys")]
        public IEnumerable<string> SiteKeys { get; set; }

        [JsonProperty(PropertyName = "serviceAreas")]
        public IEnumerable<string> ServiceAreas { get; set; }

        [JsonProperty(PropertyName = "devices")]
        public IEnumerable<string> Devices { get; set; }

        public IEnumerable<string> GraphNodeSiteKeys { get; set; }
    }
}
