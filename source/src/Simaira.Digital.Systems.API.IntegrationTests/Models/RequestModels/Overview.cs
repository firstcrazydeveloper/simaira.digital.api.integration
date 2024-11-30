namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class Overview 
    {
        [JsonProperty(PropertyName = "accountNumbers")]
        public IEnumerable<string> AccountNumbers { get; set; }

        [JsonProperty(PropertyName = "customerKey")]
        public int CustomerKey { get; set; }

        [JsonProperty(PropertyName = "features")]
        public IEnumerable<string> Features { get; set; }
    }
}
