namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class RequestPayload : IRequestPayload
    {
        [JsonProperty(PropertyName = "pageContext")]
        public FeatureContext PageContext { get; set; }

        [JsonProperty(PropertyName = "userInfo")]
        public User UserInfo { get; set; }

        [JsonProperty(PropertyName = "insight")]
        public Insight Insight { get; set; }

        [JsonProperty(PropertyName = "purchase")]
        public Purchase Purchase { get; set; }

        [JsonProperty(PropertyName = "widgets")]
        public IEnumerable<Widget> Widgets { get; set; }

        [JsonProperty(PropertyName = "sinkSurface")]
        public OverviewWidget SinkSurface { get; set; }

        [JsonProperty(PropertyName = "overview")]
        public Overview Overview { get; set; }

        [JsonProperty(PropertyName = "userHierarchy")]
        public UserHierarchy UserHierarchy { get; set; }

        [JsonProperty(PropertyName = "handCare")]
        public OverviewWidget HandCare { get; set; }

        [JsonProperty(PropertyName = "dishMachine")]
        public OverviewWidget DishMachine { get; set; }

        [JsonProperty(PropertyName = "overviewPulseCheck")]
        public IEnumerable<OverviewWidget> OverviewPulseCheck { get; set; }
    }
}
