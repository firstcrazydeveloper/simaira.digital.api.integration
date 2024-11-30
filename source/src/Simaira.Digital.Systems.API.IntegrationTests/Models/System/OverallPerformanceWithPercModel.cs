namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    public class OverallPerformanceWithPercModel
    {
        [JsonProperty(PropertyName = "insightCategory")]
        public string InsightCategory { get; set; }

        [JsonProperty(PropertyName = "overallPerformancePercentage")]
        public string OverallPerformancePercentage { get; set; }

        [JsonProperty(PropertyName = "overallPerformanceDelta")]
        public string OverallPerformanceDelta { get; set; }

        [JsonProperty(PropertyName = "overallPerformanceValue")]
        public string OverallPerformanceValue { get; set; }

        [JsonProperty(PropertyName = "trend")]
        public IEnumerable<TrendWithPercent> Trend { get; set; }
    }
}