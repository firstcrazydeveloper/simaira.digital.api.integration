namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System;

    [Serializable]
    public class CDMAccountModel
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string DivisionCode { get; set; }
        public string DivisionName { get; set; }
        public int AccountKey { get; set; }
        public int CustomerKey { get; set; }
        public int SiteKey { get; set; }
        public int GraphNodeSiteKey { get; set; }
    }
}
