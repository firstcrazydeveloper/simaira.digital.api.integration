namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using global::System.Collections.Generic;
    using global::System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    public class ChartRequestDto
    {
        [Required]
        [JsonProperty(PropertyName = "deviceGroupName")]
        public string DeviceGroupName { get; set; }

        [Required]
        [JsonProperty(PropertyName = "deviceGroupValue")]
        public string DeviceGroupValue { get; set; }

        [JsonProperty(PropertyName = "deviceIds")]
        public IEnumerable<string> DeviceIds { get; set; }

        [JsonProperty(PropertyName = "serviceAreaIds")]
        public IEnumerable<string> ServiceAreaIds { get; set; }
    }
}