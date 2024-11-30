namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System.Benchmarking
{
    using global::System;

    public class SSBenchMarkingKustoDataModel
    {
        public string CdmSiteKey { get; set; }
        public string AccountNumber { get; set; }
        public string DeviceId { get; set; }
        public decimal RefillCount { get; set; }
        public DateTime EventDate { get; set; }
    }
}
