namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using Newtonsoft.Json;

    public interface ISinkSurface
    {
        [JsonProperty(PropertyName = "sinkSurface")]
        OverviewWidget SinkSurface { get; set; }
    }
}
