namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using Newtonsoft.Json;
    public class DevicesAlertTrend
    {
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "year")]
        public string Year { get; set; }

        [JsonProperty(PropertyName = "day")]
        public string Day { get; set; }

        [JsonProperty(PropertyName = "goodRackPercentageDaily")]
        public string GoodRackPercentageDaily { get; set; }

        [JsonProperty(PropertyName = "goodRackCountDaily")]
        public string GoodRackCountDaily { get; set; }

        [JsonProperty(PropertyName = "badRackCountDaily")]
        public string BadRackCountDaily { get; set; }

        [JsonProperty(PropertyName = "rackCountDaily")]
        public string RackCountDaily { get; set; }

        [JsonProperty(PropertyName = "allAlertCountDaily")]
        public string AllAlertCountDaily { get; set; }
    }
}
