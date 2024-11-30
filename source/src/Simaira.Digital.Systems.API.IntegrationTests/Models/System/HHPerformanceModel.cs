namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System;
    using Newtonsoft.Json;

    public class HHPerformanceModel
    {
        [JsonProperty(PropertyName = "shiftWiseEventDate")]
        public DateTime? ShiftWiseEventDate { get; set; }

        [JsonProperty(PropertyName = "shiftName")]
        public string ShiftName { get; set; }

        [JsonProperty(PropertyName = "totalHandWash")]
        public Double TotalHandWash { get; set; }

        [JsonProperty(PropertyName = "totalWorker")]
        public Double? TotalWorker { get; set; }

        [JsonProperty(PropertyName = "totalHours")]
        public Double? TotalHours { get; set; }

        [JsonProperty(PropertyName = "expectedCount")]
        public Double? ExpectedCount { get; set; }

        [JsonProperty(PropertyName = "perEmployeePerHour")]
        public Double? PerEmployeePerHour { get; set; }

        [JsonProperty(PropertyName = "targetGoalPercentage")]
        public Double? TargetGoalPercentage { get; set; }
    }
}
