namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos;
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class Widget
    {
        [JsonProperty(PropertyName = "days")]
        public int Days { get; set; }

        [JsonProperty(PropertyName = "customerKey")]
        public int CustomerKey { get; set; }

        [JsonProperty(PropertyName = "pageInfo")]
        public PageInfo PageInfo { get; set; }

        [JsonProperty(PropertyName = "chartRequests")]
        public IEnumerable<ChartRequest> ChartRequests { get; set; }
    }
}
