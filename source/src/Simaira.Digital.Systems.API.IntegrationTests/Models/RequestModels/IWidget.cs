namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public interface IWidget
    {
        [JsonProperty(PropertyName = "widgets")]
        IEnumerable<Widget> Widgets { get; set; }
    }
}
