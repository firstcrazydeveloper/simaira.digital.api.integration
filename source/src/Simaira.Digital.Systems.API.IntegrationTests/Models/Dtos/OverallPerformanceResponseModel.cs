namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using Newtonsoft.Json;

    public class OverallPerformanceResponseModel
    {
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "overallPerformance")]
        public string OverallPerformance { get; set; }

        [JsonProperty(PropertyName = "overallPerformanceDelta")]
        public string OverallPerformanceDelta { get; set; }

    }
}