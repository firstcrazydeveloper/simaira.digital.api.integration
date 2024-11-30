namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using Newtonsoft.Json;

    public class PageInfo
    {
        [JsonProperty(PropertyName = "pageSize")]
        public int PageSize { get; set; }

        [JsonProperty(PropertyName = "pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty(PropertyName = "direction")]
        public string Direction { get; set; }

        [JsonProperty(PropertyName = "propertyName")]
        public string PropertyName { get; set; }
    }
}
