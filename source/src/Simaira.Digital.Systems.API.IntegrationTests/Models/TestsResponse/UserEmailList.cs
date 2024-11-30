namespace Simaira.Digital.Systems.IntegrationTests.Models.TestsResponse
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class UserEmailList
    {
        [Required]
        [JsonProperty(PropertyName = "emails")]
        public IEnumerable<string> Emails { get; set; }
    }
}
