namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class ConnectedAccountsSFDCResponse
    {
        [JsonProperty(PropertyName = "totalSize")]
        public int TotalSize { get; set; }

        [JsonProperty(PropertyName = "done")]
        public bool Done { get; set; }

        [JsonProperty(PropertyName = "records")]
        public IEnumerable<ConnectedAccount> ConnectedAccounts { get; set; }
    }
}
