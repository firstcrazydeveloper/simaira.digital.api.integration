namespace Simaira.Digital.Systems.IntegrationTests.Models.TestsResponse
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ScenarioTest
    {
        [Required]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [Required]
        [JsonProperty(PropertyName = "testName")]
        public string TestName { get; set; }

        [Required]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [Required]
        [JsonProperty(PropertyName = "featureTitle")]
        public string FeatureTitle { get; set; }

        [Required]
        [JsonProperty(PropertyName = "testClass")]
        public string TestClass { get; set; }

        [Required]
        [JsonProperty(PropertyName = "timeStamp")]
        public string TimeStamp { get; set; }

        [Required]
        [JsonProperty(PropertyName = "environment")]
        public string Environment { get; set; }

        [Required]
        [JsonProperty(PropertyName = "isScenarioContextStoreInCosmos")]
        public bool IsScenarioContextStoreInCosmos { get; set; } = false;

        [Required]
        [JsonProperty(PropertyName = "logContexts")]
        public Dictionary<string, string> LogContexts { get; set; } = new Dictionary<string, string>();
    }
}
