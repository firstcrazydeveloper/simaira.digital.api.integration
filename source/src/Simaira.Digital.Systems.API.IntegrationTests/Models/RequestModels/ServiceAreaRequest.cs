namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;
    public class ServiceAreaRequest : AccountRequest
    {
        [JsonProperty(PropertyName = "features")]
        public IEnumerable<string> Features { get; set; }
    }
}
