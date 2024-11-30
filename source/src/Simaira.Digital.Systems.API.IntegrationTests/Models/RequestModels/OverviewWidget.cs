namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using Newtonsoft.Json;

    public class OverviewWidget : Widget
    {
        [JsonProperty(PropertyName = "feature")]
        public string Feature { get; set; }

        [JsonProperty(PropertyName = "isPulseCheck")]
        public bool IsPulseCheck { get; set; }
    }
}
