namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;

    public class InsightCategoryDocument : BaseInsightDocumentModel
    {

        [JsonProperty(PropertyName = "insightTypeSubCategory")]
        public string InsightTypeSubCategory { get; set; }

        [JsonProperty(PropertyName = "stopDateTimeEpoch")]
        public string StopDateTimeEpoch { get; set; }

        [JsonProperty(PropertyName = "insightSequence")]
        public string InsightSequence { get; set; }
    }
}
