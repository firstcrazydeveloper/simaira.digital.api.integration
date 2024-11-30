namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;
    public class HandHygieneTrend
    {
        [JsonProperty(PropertyName = "deviceGroupName")]
        public string DeviceGroupName { get; set; }

        [JsonProperty(PropertyName = "deviceGroupValue")]
        public string DeviceGroupValue { get; set; }

        [JsonProperty(PropertyName = "trend")]
        public IList<TrendWithPercent> Trend { get; set; }
    }
    public class HandHygieneDailyTrend
    {
        [JsonProperty(PropertyName = "cdmSitekey")]        
        public string CDMSiteKey { get; set; }
        
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "year")]
        public string Year { get; set; }

        [JsonProperty(PropertyName = "day")]
        public string Day { get; set; }

        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        [JsonIgnore]
        public string FullDate { get; set; }

    }
}
