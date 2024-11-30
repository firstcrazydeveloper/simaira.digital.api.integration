namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;

    public class AlertData
    {
        [JsonProperty(PropertyName = "userEmail")]
        public string UserEmail { get; set; }

        [JsonProperty(PropertyName = "accountNumber")]
        public string AccountNumber { get; set; }

         [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }

        [JsonProperty(PropertyName = "serviceAreaId")]
        public string ServiceAreaId { get; set; }

        [JsonProperty(PropertyName = "serviceAreaName")]
        public string ServiceAreaName { get; set; }
        
        [JsonProperty(PropertyName = "communicationType")]
        public string CommunicationType { get; set; }

        [JsonProperty(PropertyName = "shiftEnum")]
        public int ShiftEnum { get; set; }

        [JsonProperty(PropertyName = "shiftName")]
        public string ShiftName { get; set; }

        [JsonProperty(PropertyName = "shiftDays")]
        public string ShiftDayOfWeek { get; set; }

        [JsonProperty(PropertyName = "alert")]
        public string IsAlertOpted { get; set; }
    }
}