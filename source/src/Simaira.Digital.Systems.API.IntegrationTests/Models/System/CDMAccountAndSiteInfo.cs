namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class CDMAccountAndSiteInfo
    {
        [JsonProperty(PropertyName = "accounts")]
        public List<CDMAccountsModel> Accounts { get; set; }
        [JsonProperty(PropertyName = "sites")]
        public List<CDMSitesModel> Sites { get; set; }                                                             
    }
    
    public class CDMAccountsModel
    {
        public string AccountKey { get; set; }
        public string SiteKey { get; set; }
        public string AccountNameEnglish { get; set; }
        public string AccountTypeCode { get; set; }
        public string BusinessUnitCode { get; set; }
        public string AddressLine1 { get; set; }
        public string AccountName { get; set; }
        public string AccountStatusCode { get; set; }
        public string AccountNumber { get; set; }
        public object UnitNumber { get; set; }
        public string CountryCode { get; set; }
        public string DivisionalBusinessUnitCode { get; set; }
        public string GraphNodeSiteKey { get; set; }
    }
    public class CDMSitesModel
    {
        public string SiteKey { get; set; }
        public string SourceSiteRecordId { get; set; }
        public string SiteName { get; set; }
        public string SiteLocalName { get; set; }
        public string SiteStatusCode { get; set; }
        public string City { get; set; }
        public string StateProvinceCode { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
    }

}
