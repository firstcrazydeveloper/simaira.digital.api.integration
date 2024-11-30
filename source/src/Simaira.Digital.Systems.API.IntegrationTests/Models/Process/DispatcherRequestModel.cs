
namespace Ecolab.Simaira.Digital.CustomerPortal.Model
{
    using Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos;
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class DispatcherRequestModel
    {
        [JsonProperty(PropertyName = "pageContext")]
        public PageContext PageContext { get; set; }

        [JsonProperty(PropertyName = "userAccount")]
        public UserModel UserAccount { get; set; }

        [JsonProperty(PropertyName = "alertFilter")]
        public AlertFilterUiInput AlertFilter { get; set; }

        [JsonProperty(PropertyName = "chartRequestPayload")]
        public ChartRequestPayloadDto ChartRequestPayload { get; set; }

        [JsonProperty(PropertyName = "categoryPayload")]
        public IEnumerable<ChartRequestPayloadDto> CategoryPayload { get; set; }
    }
}