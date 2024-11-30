namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;

    public class HHTrendDAXResponse    
    {
        [JsonProperty(PropertyName = "factHHdispenser[CDMSiteKey]")]
        public string CDMSiteKey { get; set; }

        [JsonProperty(PropertyName = "factHHdispenser[ServiceAreaId]")]
        public string ServiceAreaId { get; set; }

        [JsonProperty(PropertyName = "factHHdispenser[MACAddress]")]
        public string MACAddress { get; set; }

        [JsonProperty(PropertyName = "Date_table[DayAbbrevation]")]
        public string DayAbbrevation { get; set; }

        [JsonProperty(PropertyName = "Date_table[Date_]")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "[CountofEvents]")]
        public int CountofEvents { get; set; }

        [JsonProperty(PropertyName = "Date_table[Year]")]
        public int Year { get; set; }
    }
}

