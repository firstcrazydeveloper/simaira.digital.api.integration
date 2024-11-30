namespace Ecolab.Simaira.Digital.CustomerPortal.Model
{
    using Newtonsoft.Json;

    public class RecommendationDocumentModel
    {
        [JsonProperty(PropertyName = "recommendationID")]
        public string RecommendationID { get; set; }
        [JsonProperty(PropertyName = "recommendationText")]
        public string RecommendationText { get; set; }
        [JsonProperty(PropertyName = "recommendationSequence")]
        public string RecommendationSequence { get; set; }
    }
}
