namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    public class OverallPerformanceModel
    {
        [JsonProperty(PropertyName = "insightCategory")]
        public string InsightCategory { get; set; }

        [JsonProperty(PropertyName = "overallPerformance")]
        public string OverallPerformance { get; set; }

        [JsonProperty(PropertyName = "overallPerformanceDelta")]
        public string OverallPerformanceDelta { get; set; }

        [JsonProperty(PropertyName = "trend")]
        public List<Trend> Trend { get; set; }
    }
}