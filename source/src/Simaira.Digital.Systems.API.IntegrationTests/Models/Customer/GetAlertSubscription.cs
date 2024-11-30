namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    public class GetAlertSubscription
    {
        [Required(ErrorMessage = "Please enter your Email Address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [EmailAddress]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter correct email")]
        [JsonProperty(PropertyName = "userEmail")]
        public string UserEmail { get; set; }

        [Required]
        [JsonProperty(PropertyName = "accountNumber")]
        public string AccountNumber { get; set; }
    }
}