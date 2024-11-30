namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using Newtonsoft.Json;

    public interface IHandCare
    {
        [JsonProperty(PropertyName = "handCare")]
        OverviewWidget HandCare { get; set; }
    }
}
