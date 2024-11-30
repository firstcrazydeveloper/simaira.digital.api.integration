namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;
    public class ResetEmailAlertSubscriptionMessageRequest
    {
        [JsonProperty(PropertyName = "alertSubscriptioFilter")]
        public IEnumerable<AlertSubscriptioFilter> AlertSubscriptioFilter { get; set; }

        [JsonProperty(PropertyName = "isOptIn")]
        public bool IsOptIn { get; set; }
    }
}
