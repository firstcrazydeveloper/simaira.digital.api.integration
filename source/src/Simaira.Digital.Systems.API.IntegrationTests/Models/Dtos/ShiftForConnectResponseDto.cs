namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using global::System.Text.Json.Serialization;

    public class ShiftForConnectResponseDto
    {
        [JsonPropertyName("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonPropertyName("accountName")]
        public string AccountName { get; set; }

        [JsonPropertyName("serviceAreaID")]
        public string ServiceAreaID { get; set; }

        [JsonPropertyName("serviceArea")]
        public string ServiceArea { get; set; }

        [JsonPropertyName("shiftName")]
        public string ShiftName { get; set; }

        [JsonPropertyName("shiftEnum")]
        public int ShiftEnum { get; set; }

        [JsonPropertyName("shiftStartTime")]
        public string ShiftStartTime { get; set; }

        [JsonPropertyName("shiftEndTime")]
        public string ShiftEndTime { get; set; }

        [JsonPropertyName("shiftDays")]
        public string ShiftDays { get; set; }

        [JsonPropertyName("numberOfEmployees")]
        public int NumberOfEmployees { get; set; }
    }

}
