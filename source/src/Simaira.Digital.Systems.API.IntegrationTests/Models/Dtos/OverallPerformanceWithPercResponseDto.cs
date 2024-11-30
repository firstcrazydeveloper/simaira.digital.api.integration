namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using Newtonsoft.Json;
    using System;

    public class OverallPerformanceWithPercResponseDto
    {
        [JsonProperty(PropertyName = "deviceGroupName")]
        public string DeviceGroupName { get; set; }

        [JsonProperty(PropertyName = "deviceGroupValue")]
        public string DeviceGroupValue { get; set; }

        [JsonProperty(PropertyName = "overallPerformanceModel")]
        public OverallPerformanceWithPercModel OverallPerformanceModel { get; set; }
    }
}
