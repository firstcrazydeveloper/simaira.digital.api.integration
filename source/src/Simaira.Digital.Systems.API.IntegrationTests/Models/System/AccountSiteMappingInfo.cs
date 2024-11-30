namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;

    public class AccountSiteMappingInfo
    {
        public IEnumerable<AccountSiteMapping> AccountSite { get; set; }
    }

    public class AccountSiteMapping
    {
        public int AccountKey { get; set; }
        public int GraphNodeSiteKey { get; set; }
    }
}
