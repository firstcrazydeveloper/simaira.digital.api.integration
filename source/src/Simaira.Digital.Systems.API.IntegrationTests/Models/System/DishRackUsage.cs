namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;

    public class DishRackUsage
    {
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "year")]
        public string Year { get; set; }

        [JsonProperty(PropertyName = "day")]
        public string Day { get; set; }

        [JsonProperty(PropertyName = "issue")]
        public string Issue { get; set; }

        [JsonProperty(PropertyName = "noIssue")]
        public string NoIssue { get; set; }
    }
}