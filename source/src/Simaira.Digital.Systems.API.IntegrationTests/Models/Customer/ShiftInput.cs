namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    public class ShiftInput
    {
        [Required]
        [JsonProperty(PropertyName = "accountNumber")]
        public string AccountNumber { get; set; }
    }
}