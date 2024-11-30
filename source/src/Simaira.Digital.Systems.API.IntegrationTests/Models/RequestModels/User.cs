namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using global::System.Collections.Generic;
    using global::System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    public class User
    {
        [JsonProperty(PropertyName = "customerKey")]
        public int CustomerKey { get; set; }

        [RegularExpression(Constants.EmailRegExpression, ErrorMessage = "Please enter correct email")]
        [DataType(DataType.EmailAddress)]
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "accountNumbers")]
        public IEnumerable<string> AccountNumbers { get; set; }

        [JsonProperty(PropertyName = "siteKeys")]
        public IEnumerable<string> SiteKeys { get; set; }

        [JsonProperty(PropertyName = "features")]
        public IEnumerable<string> Features { get; set; }

        [JsonProperty(PropertyName = "graphNodeSiteKeys")]
        public IEnumerable<string> GraphNodeSiteKeys { get; set; }

        [JsonProperty(PropertyName = "h7Id")]
        public string H7Id { get; set; }
    }
}
