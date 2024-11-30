namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;

    public class Shift
    {
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
    }
}