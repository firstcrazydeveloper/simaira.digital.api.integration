namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Process
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class CustomerHierarchyResponseModel : BaseApiResponse
    {
        public IEnumerable<CustomerHierarchyModel> Hierarchy { get; set; }
    }
    public class CustomerHierarchyModel : HierarchyModel
    {
        [JsonProperty(PropertyName = "accountNumber")]
        public string AccountNumber { get; set; }
    }
}
