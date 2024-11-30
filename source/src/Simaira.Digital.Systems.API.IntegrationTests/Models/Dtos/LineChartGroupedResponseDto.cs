namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using Ecolab.Simaira.Digital.CustomerPortal.Model.System;
    using Newtonsoft.Json;


    public class LineChartGroupedResponseDto
    {
        [JsonProperty(PropertyName = "deviceGroupName")]
        public string DeviceGroupName { get; set; }

        [JsonProperty(PropertyName = "deviceGroupValue")]
        public string DeviceGroupValue { get; set; }

        [JsonProperty(PropertyName = "overallPerformanceModel")]
        public LineChartGroupedDataModel OverallPerformanceModel { get; set; }
    }
}
