namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System.Collections.Generic;
    using Newtonsoft.Json;

    public class ServiceAreaQueryResponse
    {
        [JsonProperty(PropertyName = "totalSize")]
        public int TotalSize { get; set; }
        [JsonProperty(PropertyName = "done")]
        public bool Done { get; set; }
        [JsonProperty(PropertyName = "records")]
        public List<ServiceAreaQueryResponseModel> Records { get; set; }
    }
    public class ServiceAreaQueryResponseModel
    {
        public string Linked_Asset_Serial_Number__c { get; set; }
        public string Name { get; set; }
        public ServiceAreaQueryLocationResponseModel Location { get; set; }
        public string LocationId { get; set; }
        public ServiceAreaQueryApplicationResponseModel Linked_Asset_ID__r { get; set; }

        public ServiceAreaDeviceAccount Account { get; set; }

        public string Device_Serial_Number__c { get; set; }

        public string Dispenser_Product__c { get; set; }
    }

    public class ServiceAreaQueryLocationResponseModel
    {
        public string Name { get; set; }
    }

    public class ServiceAreaQueryApplicationResponseModel
    {
        public string Application_Type__c { get; set; }
    }

    public class ServiceAreaDeviceAccount
    {
        public string AccountNumber { get; set; }
    }

}