namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;

    public class CustomerGoal
    {
        [JsonProperty(PropertyName = "customerKey")]
        public int CustomerKey { get; set; }

        [JsonProperty(PropertyName = "percentGoodRacks")]
        public double? PercentGoodRacks { get; set; }

        [JsonProperty(PropertyName = "handWashes")]
        public int? HandWashes { get; set; }

        [JsonProperty(PropertyName = "sinkSurfaceCompleted")]
        public int? SinkSurfaceCompleted { get; set; }
    }
}
