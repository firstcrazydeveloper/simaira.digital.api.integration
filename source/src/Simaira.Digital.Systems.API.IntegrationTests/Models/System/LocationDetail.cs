namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;

    public class LocationDetail
    {
        [JsonProperty(PropertyName = "graphNodeSiteKey")]
        public int GraphNodeSiteKey { get; set; }

        [JsonProperty(PropertyName = "siteKey")]
        public string SiteKey { get; set; }

        [JsonProperty(PropertyName = "siteName")]
        public string SiteName { get; set; }

        [JsonProperty(PropertyName = "addressLine")]
        public string AddressLine { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "latitude")]
        public string Latitude { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public string Longitude { get; set; }
 
    }
}
