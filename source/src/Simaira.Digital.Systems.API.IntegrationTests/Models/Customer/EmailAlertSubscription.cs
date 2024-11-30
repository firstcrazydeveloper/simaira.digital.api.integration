namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    public class EmailAlertSubscription
    {
        [Required(ErrorMessage = "Please enter your Email Address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter correct email")]
        [EmailAddress]
        [JsonProperty(PropertyName = "userEmail")]
        public string UserEmail { get; set; }

        [Required]
        [JsonProperty(PropertyName = "accountNumber")]
        public string AccountNumber { get; set; }

        [Required]
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }

        [Required]
        [JsonProperty(PropertyName = "serviceAreaId")]
        public string ServiceAreaId { get; set; }

        [Required]
        [JsonProperty(PropertyName = "serviceAreaName")]
        public string ServiceAreaName { get; set; }

        [Required]
        [JsonProperty(PropertyName = "communicationType")]
        public string CommunicationType { get; set; }

        [JsonProperty(PropertyName = "shiftEnum")]
        public int ShiftEnum { get; set; }

        [JsonProperty(PropertyName = "shiftName")]
        public string ShiftName { get; set; }

        [JsonProperty(PropertyName = "shiftDays")]
        public string ShiftDayOfWeek { get; set; }

        [Required]
        [JsonProperty(PropertyName = "alert")]
        public string IsAlertOpted { get; set; }
    }
}