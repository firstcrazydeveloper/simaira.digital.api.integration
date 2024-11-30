namespace Ecolab.Simaira.Digital.CustomerPortal.Model
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;


    public class Bubblechart
    {
        [JsonProperty(PropertyName = "attributes")]
        public List<BubbleAttribute> Attributes { get; set; }


        [JsonProperty(PropertyName = "alertCount")]
        public string AlertCount { get; set; }
    }
}
