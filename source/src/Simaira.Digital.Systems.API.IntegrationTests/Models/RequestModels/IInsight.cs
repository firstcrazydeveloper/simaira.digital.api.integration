using Newtonsoft.Json;

namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    public interface IInsight
    {
        [JsonProperty(PropertyName = "insight")]
        Insight Insight { get; set; }
    }
}
