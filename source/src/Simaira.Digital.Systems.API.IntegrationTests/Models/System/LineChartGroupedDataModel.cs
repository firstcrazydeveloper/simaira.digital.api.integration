namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class LineChartGroupedDataModel
    {
        [JsonProperty(PropertyName = "insightCategory")]
        public string InsightCategory { get; set; }

        [JsonProperty(PropertyName = "trend")]
        public IEnumerable<LineChartGroupTrend> Trend { get; set; }
    }
}
