namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using global::System.Collections.Generic;
    using global::System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;
    using static Ecolab.Simaira.Digital.CustomerPortal.Model.Constants;

    public class ServiceAreaDetailsRequestDto
    {
        [Required(ErrorMessage = "Please enter Program Category")]
        [JsonProperty(PropertyName = "programCategory")]
        public IEnumerable<ProgramCategory> ProgramCategory { get; set; }

        [Required(ErrorMessage = "Please enter Account Number")]
        [JsonProperty(PropertyName = "accountNumbers")]
        public IEnumerable<string> AccountNumbers { get; set; }
    }
}