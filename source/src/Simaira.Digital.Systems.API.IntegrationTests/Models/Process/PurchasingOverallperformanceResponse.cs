namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Process
{
    using Newtonsoft.Json;

    public class PurchasingOverallperformanceResponse
    {
        [JsonProperty(PropertyName = "notPurchased")]
        public double NotPurchased { get; set; }

        [JsonProperty(PropertyName = "totalCategories")]
        public string TotalCategories { get; set; }
    }
}
