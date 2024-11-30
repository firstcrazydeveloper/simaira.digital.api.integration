namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System;
    using Newtonsoft.Json;

    public class ShiftForAnalytics
    {
        [JsonProperty(PropertyName = "customerKey")]
        public int CustomerKey { get; set; }

        [JsonProperty(PropertyName = "globalKey")]
        public int GlobalKey { get; set; }

        [JsonProperty(PropertyName = "customerSiteKey")]
        public string CustomerSiteKey { get; set; }

        [JsonProperty(PropertyName = "accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }

        [JsonProperty(PropertyName = "serviceAreaID")]
        public string ServiceAreaID { get; set; }

        [JsonProperty(PropertyName = "serviceAreaName")]
        public string ServiceArea { get; set; }

        [JsonProperty(PropertyName = "shiftCategoryLabel")]
        public string ShiftCategoryLabel { get; set; }

        [JsonProperty(PropertyName = "shiftDayOfWeek")]
        public string ShiftDayOfWeek { get; set; }

        [JsonProperty(PropertyName = "shiftEnumeration")]
        public int ShiftEnumeration { get; set; }

        [JsonProperty(PropertyName = "shiftName")]
        public string ShiftName { get; set; }

        [JsonProperty(PropertyName = "startTime")]
        public TimeSpan? StartTime { get; set; }

        [JsonProperty(PropertyName = "endTime")]
        public TimeSpan? EndTime { get; set; }

        [JsonProperty(PropertyName = "numberOfWorkers")]
        public int? NumberOfWorkers { get; set; }
    }
}