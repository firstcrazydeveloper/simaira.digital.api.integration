namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    public class DishRacksUsageTrend
    {
        [JsonProperty(PropertyName = "total", Order = 1)]
        public string Total { get; set; }

        [JsonProperty(PropertyName = "dishRackUsage", Order = 2)]
        public List<DishRackUsage> DishRackUsage { get; set; }
    }
}