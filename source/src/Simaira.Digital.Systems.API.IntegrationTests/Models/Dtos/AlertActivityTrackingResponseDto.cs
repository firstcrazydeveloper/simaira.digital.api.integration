namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using Newtonsoft.Json;
    using System;

    public class AlertActivityTrackingResponseDto
    {
        [JsonProperty(PropertyName = "deviceGroupName")]
        public string DeviceGroupName { get; set; }

        [JsonProperty(PropertyName = "deviceGroupValue")]
        public string DeviceGroupValue { get; set; }

        [JsonProperty(PropertyName = "alertActivityTracking")]
        public AlertActivityTracking AlertActivityTracking { get; set; }
    }
}
