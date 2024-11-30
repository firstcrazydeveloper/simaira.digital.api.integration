namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using global::System.Collections.Generic;
    using global::System.ComponentModel.DataAnnotations;
    using global::System.Text.Json.Serialization;
    using Newtonsoft.Json;

    public class AccountServiceAreaShiftReqDto
    {
        [JsonPropertyName("accountNumber")]
        [Required]
        public string AccountNumber { get; set; }
        [JsonPropertyName("serviceAreaID")]
        [Required]
        public IList<string> ServiceAreaId { get; set; }

    }


}
