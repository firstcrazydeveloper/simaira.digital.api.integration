namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class ServiceArea
    {
        [JsonProperty(PropertyName = "serviceAreaId")]
        public string ServiceAreaId { get; set; }

        [JsonProperty(PropertyName = "accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty(PropertyName = "devices")]
        public IDictionary<string, string> Devices { get; set; } = new Dictionary<string, string>();
    }
}
