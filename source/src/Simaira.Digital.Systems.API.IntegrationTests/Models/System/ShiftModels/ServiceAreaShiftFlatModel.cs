namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    public  class ServiceAreaShiftFlatModel
    {
        public int CustomerKey { get; set; }
        public string CdmsiteKey { get; set; }
        public double? TimeZone { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string ServiceAreaId { get; set; }
        public string ServiceAreaName { get; set; }
        public int ShiftDayOfWeek { get; set; }
        public int ShiftEnumeration { get; set; }
        public string ShiftName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int? NumberOfWorkers { get; set; }
        public bool? IsActive { get; set; }

    }


}
