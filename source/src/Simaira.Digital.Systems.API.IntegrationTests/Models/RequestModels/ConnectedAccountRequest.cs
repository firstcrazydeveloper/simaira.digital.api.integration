namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using Newtonsoft.Json;
    public class ConnectedAccountRequest
    {
        [JsonProperty(PropertyName = "h7Id")]
        public string H7Id { get; set; }
    }
}
