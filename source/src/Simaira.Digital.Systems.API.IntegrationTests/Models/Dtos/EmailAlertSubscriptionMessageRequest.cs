namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using Newtonsoft.Json;
    public class EmailAlertSubscriptionMessageRequest
    {
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "isOptIn")]
        public bool IsOptIn { get; set; }
    }
}
