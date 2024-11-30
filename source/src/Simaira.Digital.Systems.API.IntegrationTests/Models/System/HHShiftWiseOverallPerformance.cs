namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    public class HHShiftWiseOverallPerformance
    {
        [JsonProperty(PropertyName = "insightCategory")]
        public string InsightCategory { get; set; }

        [JsonProperty(PropertyName = "overallPerformanceTargetPercentage")]
        public string OverallPerformanceTargetPercentage { get; set; }

        [JsonProperty(PropertyName = "overallPerformanceDelta")]
        public string OverallPerformanceDelta { get; set; }

        [JsonProperty(PropertyName = "overallPerformanceValue")]
        public string OverallPerformanceValue { get; set; }

        [JsonProperty(PropertyName = "trend")]
        public IEnumerable<HHShiftTrend> Trend { get; set; }

        [JsonProperty(PropertyName = "expectedCount")]
        public string ExpectedCount { get; set; }

        [JsonProperty(PropertyName = "deltaExpectedCount")]
        public string DeltaExpectedCount { get; set; }

        [JsonProperty(PropertyName = "totalHandWash")]
        public string TotalHandWash { get; set; }

        [JsonProperty(PropertyName = "deltaTotalHandWash")]
        public string DeltaTotalHandWash { get; set; }
    }
}