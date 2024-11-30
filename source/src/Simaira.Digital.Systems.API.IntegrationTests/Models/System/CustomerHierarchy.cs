namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Newtonsoft.Json;

    public class CustomerHierarchy : HierarchyLevel
    {
        [JsonProperty(PropertyName = "dimAccount[AccountNumber]")]
        public string AccountNumber { get; set; }
    }
}
