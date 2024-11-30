namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using global::System.Collections.Generic;
    using global::System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    public class ChartRequestPayloadDto
    {
        [Required]
        [JsonProperty(PropertyName = "numberOfDays")]
        public int NumberOfDays { get; set; }

        [JsonProperty(PropertyName = "pageInfo")]
        public PageInfo PageInfo { get; set; }

        [Required]
        [JsonProperty(PropertyName = "chartRequest")]
        public IEnumerable<ChartRequestDto> ChartRequest { get; set; }

        [JsonProperty(PropertyName = "insightCategory")]
        public string InsightCategory { get; set; }
    }
}