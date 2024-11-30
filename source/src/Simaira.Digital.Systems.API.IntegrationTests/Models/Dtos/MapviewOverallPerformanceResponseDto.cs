namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class MapviewOverallPerformanceResponseDto
    {
        [JsonProperty(PropertyName = "deviceGroupName")]
        public string DeviceGroupName { get; set; }

        [JsonProperty(PropertyName = "deviceGroupValue")]
        public string DeviceGroupValue { get; set; }

        [JsonProperty(PropertyName = "overallPerformances")]
        public List<OverallPerformanceResponseModel> OverallPerformances { get; set; }
    }

    
}
