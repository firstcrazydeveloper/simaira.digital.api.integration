namespace Ecolab.Simaira.Digital.CustomerPortal.Model.ResponseModels
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class APIInfo
    {
        [JsonProperty(PropertyName = "requestPayloadSchema")]
        public object RequestPayloadSchema { get; set; }

        [JsonProperty(PropertyName = "responsePayloadSchema")]
        public object ResponsePayloadSchema { get; set; }

        [JsonProperty(PropertyName = "requestPayload")]
        public JToken RequestPayload { get; set; }

        [JsonProperty(PropertyName = "responsePayload")]
        public JToken ResponsePayload { get; set; }
    }
}
