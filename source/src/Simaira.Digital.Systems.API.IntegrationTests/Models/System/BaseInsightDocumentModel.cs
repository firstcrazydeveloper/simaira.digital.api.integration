namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;

    public class BaseInsightDocumentModel
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "cdmSiteKey")]
        public string CDMSiteKey { get; set; }

        [JsonProperty(PropertyName = "graphnodeSitekey")]
        public string GraphNodeSiteKey { get; set; }

        [JsonProperty(PropertyName = "startDateTimeEpoch")]
        public string StartDateTimeEpoch { get; set; }
    }
}
