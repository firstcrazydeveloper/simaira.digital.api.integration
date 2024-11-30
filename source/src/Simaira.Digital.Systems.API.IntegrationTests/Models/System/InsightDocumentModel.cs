namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class InsightDocumentModel : BaseInsightDocumentModel
    {
        [JsonProperty(PropertyName = "candidateInsightID")]
        public string CandidateInsightID { get; set; }

        [JsonProperty(PropertyName = "insightId")]
        public string InsightId { get; set; }

        [JsonProperty(PropertyName = "shift")]
        public string Shift { get; set; }

        [JsonProperty(PropertyName = "insightSource")]
        public string InsightSource { get; set; }

        [JsonProperty(PropertyName = "insightCreationDateTimeEpoch")]
        public string InsightCreationDateTimeEpoch { get; set; }

        [JsonProperty(PropertyName = "stopDateTimeEpoch")]
        public string StopDateTimeEpoch { get; set; }

        [JsonProperty(PropertyName = "periodQualifier")]
        public string PeriodQualifier { get; set; }

        [JsonProperty(PropertyName = "cdmCustomerKey")]
        public string CDMCustomerKey { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty(PropertyName = "serviceArea")]
        public string ServiceArea { get; set; }

        [JsonProperty(PropertyName = "serviceAreaID")]
        public string ServiceAreaID { get; set; }

        [JsonProperty(PropertyName = "deviceID")]
        public string DeviceID { get; set; }

        [JsonProperty(PropertyName = "machineName")]
        public string MachineName { get; set; }

        [JsonProperty(PropertyName = "testInsight")]
        public string TestInsight { get; set; }

        [JsonProperty(PropertyName = "testInsightState")]
        public string TestInsightState { get; set; }

        [JsonProperty(PropertyName = "insightTypeID")]
        public string InsightTypeID { get; set; }

        [JsonProperty(PropertyName = "insightDescription")]
        public string InsightDescription { get; set; }

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

        [JsonProperty(PropertyName = "insightTypeAbbreviation")]
        public string InsightTypeAbbreviation { get; set; }

        [JsonProperty(PropertyName = "insightDescriptionText")]
        public string InsightDescriptionText { get; set; }

        [JsonProperty(PropertyName = "insightDescriptionTextParameters")]
        public string InsightDescriptionTextParameters { get; set; }

        [JsonProperty(PropertyName = "eventDateTimeMinEpoch")]
        public string EventDateTimeMinEpoch { get; set; }

        [JsonProperty(PropertyName = "eventDateTimeMaxEpoch")]
        public string EventDateTimeMaxEpoch { get; set; }

        [JsonProperty(PropertyName = "insightResultParameters")]
        public string InsightResultParameters { get; set; }

        public InsightResultParameter InsightResultParametersObj
        {
            get
            {
                try
                {
                    return string.IsNullOrEmpty(InsightResultParameters) ? null : JsonConvert.DeserializeObject<InsightResultParameter>(InsightResultParameters);
                }
                catch { return null; }
            }
        }

        [JsonProperty(PropertyName = "audience")]
        public List<AudienceModel> Audience { get; set; }
    }
}
