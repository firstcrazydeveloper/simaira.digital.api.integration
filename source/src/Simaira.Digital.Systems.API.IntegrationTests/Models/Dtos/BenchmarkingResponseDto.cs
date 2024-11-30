namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using Ecolab.Simaira.Digital.CustomerPortal.Model.System.Benchmarking;
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class BenchmarkingResponseDto : BaseApiResponse
    {
        [JsonProperty(PropertyName = "benchmarkings")]
        public IDictionary<string, BenchmarkingResponseModel> Benchmarkings { get; set; }
    }
}
