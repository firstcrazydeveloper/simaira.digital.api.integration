namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System;
    using global::System.Collections.Generic;

    public class CDMAccountInfo
    {
        public List<CDMAccountInfoModel> Account { get; set; }
    }
    public class CDMAccountInfoModel
    {
        public int AccountKey { get; set; }
        public int ParentAccountKey { get; set; }
        public int CustomerKey { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountNameEnglish { get; set; }
        public string CustomerAccountName { get; set; }
        public string ParentAccountNumber { get; set; }
        public string SoldToAccountNumber { get; set; }
        public string PartnerFunction { get; set; }
        public string AccountStatusCode { get; set; }
        public string AccountTypeCode { get; set; }
        public bool IsDemo { get; set; }
        public string SalesOrg { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string CountryIso3Code { get; set; }
        public string BusinessUnitCode { get; set; }
        public string SourceSystemCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int DataIntgExecId { get; set; }
        public string BusinessUnitName { get; set; }
        public string StateProvinceCode { get; set; }
        public string OriginationAccountSystemCode { get; set; }
        public string DivisionalBusinessUnitCode { get; set; }
        public string DivisionalBusinessUnitName { get; set; }
        public string GlobalBusinessUnitCode { get; set; }
        public string GlobalBusinessUnitName { get; set; }
        public string AccountName2 { get; set; }
        public string AccountName3 { get; set; }
        public string AccountName4 { get; set; }
        public string GraphNodeSiteKey { get; set; }
    }
}
