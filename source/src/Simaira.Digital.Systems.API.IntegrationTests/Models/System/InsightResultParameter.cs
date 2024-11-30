namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;

    public class InsightResultParameter
    {
        public string ModelID { get; set; }

        public bool ModelScore { get; set; }

        public string ModelScoreType { get; set; }

        public string Measure { get; set; }

        public string MeasureUOM { get; set; }

        public string MeasureValue { get; set; }

        public string CandidateInsightSystemReference { get; set; }

        public int EventDateTimeUtc_week_of_year_first { get; set; }

        public long EventDateTimeUtc_min { get; set; }

        public long EventDateTimeUtc_max { get; set; }

        public long Event_assigned_to_date_utc { get; set; }

        public int Pct_racks_in_alarm_state { get; set; }

        public long StartTime { get; set; }

        public long StopTime { get; set; }

        public long StartDateTime { get; set; }

        public long StopDateTime { get; set; }

        public string HandHygieneAttributes { get; set; }

        public HandHygieneAttributes HandHygieneAttributesObj
        {
            get
            {
                try
                {
                    return string.IsNullOrEmpty(HandHygieneAttributes) ? null : JsonConvert.DeserializeObject<HandHygieneAttributes>(HandHygieneAttributes);
                }
                catch { return null; }
            }
        }

        public string DowShift { get; set; }
    }
}
