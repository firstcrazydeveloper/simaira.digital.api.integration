namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class SiteDetailsCDMResponse
    {
        [JsonProperty(PropertyName = "site")]
        public List<SiteDetailsCDMResponseModel> Site { get; set; }
    }
    public class SiteDetailsCDMResponseModel
    {
        [JsonProperty(PropertyName = "graphNodeSiteKey")]
        public int GraphNodeSiteKey { get; set; }

        [JsonProperty(PropertyName = "contextPointKey")]
        public int ContextPointKey { get; set; }

        [JsonProperty(PropertyName = "siteKey")]
        public int SiteKey { get; set; }

        [JsonProperty(PropertyName = "siteName")]
        public string SiteName { get; set; }

        [JsonProperty(PropertyName = "addressLine1")]
        public string AddressLine { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "stateProvince")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty(PropertyName = "countryIso3Code")]
        public string CountryIso3Code { get; set; }

        [JsonProperty(PropertyName = "isActive")]
        public bool IsActive { get; set; }

        [JsonProperty(PropertyName = "latitude")]
        public string Latitude { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public string Longitude { get; set; }
    }
}
