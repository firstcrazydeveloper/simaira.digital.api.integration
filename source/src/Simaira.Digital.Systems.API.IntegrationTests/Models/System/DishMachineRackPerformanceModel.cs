namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System;
    using Newtonsoft.Json;

    public class DishMachineRackPerformanceModel
    {
        [JsonProperty(PropertyName = "shiftWiseEventDate")]
        public DateTime? ShiftWiseEventDate { get; set; }

        [JsonProperty(PropertyName = "shiftName")]
        public string ShiftName { get; set; }

        [JsonProperty(PropertyName = "totalRackCount")]
        public int TotalRackCount { get; set; }

        [JsonProperty(PropertyName = "totalWorker")]
        public Double? TotalWorker { get; set; }

        [JsonProperty(PropertyName = "totalHours")]
        public Double? TotalHours { get; set; }

        [JsonProperty(PropertyName = "alarmStateRackCount")]
        public int AlarmStateRackCount { get; set; }

        [JsonProperty(PropertyName = "rackPerformance")]
        public double RackPerformance { get; set; }

        [JsonProperty(PropertyName = "siteIdentifier")]
        public string SiteIdentifier { get; set; }
    }
}
