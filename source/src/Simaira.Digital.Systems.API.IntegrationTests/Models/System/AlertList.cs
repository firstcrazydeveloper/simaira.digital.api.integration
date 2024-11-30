namespace Ecolab.Simaira.Digital.CustomerPortal.Model
{
    using Newtonsoft.Json;

    public class AlertList
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "insightCreationDateTime")]
        public string InsightCreationDateTime { get; set; }

        [JsonProperty(PropertyName = "shift")]
        public string Shift { get; set; }

        [JsonProperty(PropertyName = "insightSource")]
        public string InsightSource { get; set; }

        [JsonProperty(PropertyName = "startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty(PropertyName = "stopDateTime")]
        public string StopDateTime { get; set; }

        [JsonProperty(PropertyName = "periodQualifier")]
        public string PeriodQualifier { get; set; }

        [JsonProperty(PropertyName = "cdmCustomerKey")]
        public string CDMCustomerKey { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "cdmSiteKey")]
        public string CDMSiteKey { get; set; }

        [JsonProperty(PropertyName = "graphNodeSiteKey")]
        public string GraphNodeSiteKey { get; set; }

        [JsonProperty(PropertyName = "accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty(PropertyName = "serviceAreaID")]
        public string ServiceAreaID { get; set; }

        [JsonProperty(PropertyName = "serviceArea")]
        public string ServiceArea { get; set; }

        [JsonProperty(PropertyName = "deviceID")]
        public string DeviceID { get; set; }

        [JsonProperty(PropertyName = "machineName")]
        public string MachineName { get; set; }

        [JsonProperty(PropertyName = "insightProgram")]
        public string InsightProgram { get; set; }

        [JsonProperty(PropertyName = "insightTypeCategory")]
        public string InsightTypeCategory { get; set; }

        [JsonProperty(PropertyName = "insightTypeCategorySequence")]
        public string InsightTypeCategorySequence { get; set; }

        [JsonProperty(PropertyName = "insightTypeSubCategory")]
        public string InsightTypeSubCategory { get; set; }

        [JsonProperty(PropertyName = "insightSequence")]
        public string InsightSequence { get; set; }

        [JsonProperty(PropertyName = "insightDescriptionText")]
        public string InsightDescriptionText { get; set; }

        [JsonProperty(PropertyName = "insightDescriptionTextParameters")]
        public string InsightDescriptionTextParameters { get; set; }

        [JsonProperty(PropertyName = "audience")]
        public AudienceModel Audience { get; set; }

        public string WeekDay { get; set; }        
        [JsonProperty(PropertyName = "isrecurrence")]

        public string IsRecurrence { get; set; }
        [JsonProperty(PropertyName = "recurringCount")]

        public string RecurringCount { get; set; }
    }
}
