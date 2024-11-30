namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;

    public class HHInsightDocumentModel : BaseInsightDocumentModel
    {
        [JsonProperty(PropertyName = "serviceAreaID")]
        public string ServiceAreaID { get; set; }
        [JsonProperty(PropertyName = "insightResultParameters")]
        public string InsightResultParameters { get; set; }
        public InsightResultParameter InsightResultParametersObj
        {
            get
            {
                try
                {
                    return string.IsNullOrEmpty(InsightResultParameters) ? null : JsonConvert.DeserializeObject<InsightResultParameter>(InsightResultParameters);
                }
                catch { return null; }
            }
        }
    }
}
