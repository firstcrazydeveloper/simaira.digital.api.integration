namespace Ecolab.Simaira.Digital.CustomerPortal.Model
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class VisualAlerts
    {
        [JsonProperty(PropertyName = "bubbleChartData", Order = 1)]
        public IEnumerable<Bubblechart> BubbleChartData { get; set; }

        [JsonProperty(PropertyName = "alertList", Order = 2)]
        public IEnumerable<AlertList> AlertList { get; set; }
        
    }
}
