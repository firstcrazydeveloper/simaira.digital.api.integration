namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;
    public class AccountDto
    {
        [JsonProperty(PropertyName = "account")]
        public IEnumerable<AccountDetailsDto> Accounts { get; set; }
    }
}
