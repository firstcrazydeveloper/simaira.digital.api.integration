namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;

    public class TrendWithPercent : Trend
    {
        [JsonProperty(PropertyName = "percentageValue")]
        public string PercentageValue { get; set; }
    }
}
