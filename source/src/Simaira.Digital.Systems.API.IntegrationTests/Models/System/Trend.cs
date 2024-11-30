namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;

    public class Trend
    {
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "year")]
        public string Year { get; set; }

        [JsonProperty(PropertyName = "day")]
        public string Day { get; set; }

        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}