namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using Newtonsoft.Json;
    
    public class AlertSubscriptioFilter
    {
        [JsonProperty(PropertyName = "accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty(PropertyName = "serviceAreaId")]
        public string ServiceAreaId { get; set; }

    }
}
