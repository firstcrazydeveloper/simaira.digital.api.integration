namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class LineChartKeyValueDataModel
    {
        [JsonProperty(PropertyName = "insightCategory")]
        public string InsightCategory { get; set; }

        [JsonProperty(PropertyName = "trend")]
        public IEnumerable<LineChartKeyValueTrend> Trend { get; set; }
    }
}
