namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using Newtonsoft.Json;

    public interface IDishMachine
    {
        [JsonProperty(PropertyName = "dishMachine")]
        OverviewWidget DishMachine { get; set; }
    }
}
