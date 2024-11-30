namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;

    public class HHShiftTrend
    {
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "year")]
        public string Year { get; set; }

        [JsonProperty(PropertyName = "day")]
        public string Day { get; set; }
        

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "totalHandWash")]
        public string TotalHandWash { get; set; }

        [JsonProperty(PropertyName = "perEmployeePerHour")]
        public string PerEmployeePerHour { get; set; }

        [JsonProperty(PropertyName = "targetGoalPercentage")]
        public string TargetGoalPercentage { get; set; }

        [JsonProperty(PropertyName = "totalHours")]
        public string TotalHours { get; set; }

        [JsonProperty(PropertyName = "totalWorkers")]
        public string TotalWorkers { get; set; }
    }
}