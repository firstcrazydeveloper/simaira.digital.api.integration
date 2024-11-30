namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;
    using global::System.Text.Json.Serialization;
    using Newtonsoft.Json;

    public class CDMUserAlignment
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("isMultiSiteUser")]
        public bool IsMultiSiteUser { get; set; }

        [JsonPropertyName("siteKey")]
        public object SiteKey { get; set; }

        [JsonPropertyName("siteName")]
        public object SiteName { get; set; }
    }
}
