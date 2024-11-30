namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;
    public class AccountRequest
    {
        [JsonProperty(PropertyName = "accountNumbers")]
        public IEnumerable<string> AccountNumbers { get; set; }
    }
}
