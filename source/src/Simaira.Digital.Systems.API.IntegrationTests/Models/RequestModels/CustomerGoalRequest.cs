namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using Newtonsoft.Json;
    public class CustomerGoalRequest
    {
        [JsonProperty(PropertyName = "customerKey")]
        public int CustomerKey { get; set; }
    }
}
