namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class AlertActivityTracking
    {
        [JsonProperty(PropertyName = "insightCategory")]
        public string InsightCategory { get; set; }

        [JsonProperty(PropertyName = "alertTotalCount")]
        public string AlertTotalCount { get; set; }

        [JsonProperty(PropertyName = "trend")]
        public List<Trend> Trend { get; set; }
    }

    public static partial class Extensions
    {
        public static bool IsNullOrEmpty(this AlertActivityTracking model)
        {
            if (model == null || (model != null && string.IsNullOrEmpty(model.AlertTotalCount) && string.IsNullOrEmpty(model.InsightCategory) && (model.Trend == null || model.Trend.Count == 0)))
                return true;
            return false;
        }
    }
}