namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System.ShiftModels
{
    using global::System;
    using global::System.ComponentModel.DataAnnotations;
    using global::System.Text.Json.Serialization;

    public class ServiceAreaShiftConnectModel
    {
        [JsonPropertyName("accountNumber")]
        [Required]
        public string AccountNumber { get; set; }

        [JsonPropertyName("accountName")]
        [Required]
        public string AccountName { get; set; }

        [JsonPropertyName("serviceAreaID")]
        [Required]
        public string ServiceAreaId { get; set; }

        [JsonPropertyName("serviceArea")]
        [Required]
        public string ServiceArea { get; set; }

        [JsonPropertyName("shiftName")]
        [Required]
        public string ShiftName { get; set; }

        [JsonPropertyName("shiftEnum")]
        public int ShiftEnum { get; set; }

        [JsonPropertyName("shiftStartTime")]
        [Required]
        [DataType(DataType.Time)]
        [Range(typeof(TimeSpan), "00:00:00", "23:59:59")]
        public string ShiftStartTime { get; set; }

        [JsonPropertyName("shiftEndTime")]
        [Required]
        [DataType(DataType.Time)]
        [Range(typeof(TimeSpan),"00:00:00","23:59:59")]
        public string ShiftEndTime { get; set; }

        [JsonPropertyName("shiftDays")]
        [Required] [CustomDayNameValidation]
        public string ShiftDays { get; set; }

        [JsonPropertyName("locationTimeZone")]
        [Required][Range(-24, 24)]
        public double? LocationTimeZone { get; set; }

        [JsonPropertyName("numberOfEmployees")]
        [Required]
        public int NumberOfEmployees { get; set; }
    }
}
