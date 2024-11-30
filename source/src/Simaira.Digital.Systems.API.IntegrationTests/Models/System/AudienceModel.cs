namespace Ecolab.Simaira.Digital.CustomerPortal.Model
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class AudienceModel
    {
        [JsonProperty(PropertyName = "audienceKey")]
        public string AudienceKey { get; set; }

        [JsonProperty(PropertyName = "audienceDescription")]
        public string AudienceDescription { get; set; }

        [JsonProperty(PropertyName = "recommendations")]
        public List<RecommendationDocumentModel> Recommendations { get; set; }

        [JsonProperty(PropertyName = "training")]
        public TrainingModel Training { get; set; }
    }
}
