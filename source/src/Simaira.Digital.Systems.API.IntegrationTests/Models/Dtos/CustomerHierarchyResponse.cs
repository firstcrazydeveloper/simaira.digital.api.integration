namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    using Ecolab.Simaira.Digital.CustomerPortal.Model.System;
    using global::System.Collections.Generic;

    public class CustomerHierarchyResponse : BaseApiResponse
    {
        public IEnumerable<CustomerHierarchy> Hierarchy { get; set; }
    }
}
