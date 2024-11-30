namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using Newtonsoft.Json;

    public class AccountDetailsDto
    {
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }

        [JsonProperty(PropertyName = "accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty(PropertyName = "customerAccountName")]
        public string CustomerAccountName { get; set; }

        [JsonProperty(PropertyName = "accountKey")]
        public int AccountKey { get; set; }

        [JsonProperty(PropertyName = "customerKey")]
        public int CustomerKey { get; set; }
    }
}
