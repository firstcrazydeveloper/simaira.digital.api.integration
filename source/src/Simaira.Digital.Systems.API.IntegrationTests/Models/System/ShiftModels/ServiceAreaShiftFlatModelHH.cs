namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System;

    public  class ServiceAreaShiftFlatModelHH
    {
        public int CustomerKey { get; set; }
        public string SiteIdentifier { get; set; }
        public double? TimeZone { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string ServiceAreaId { get; set; }
        public string ServiceAreaName { get; set; }
        public int ShiftDayOfWeek { get; set; }
        public int ShiftEnumeration { get; set; }
        public string ShiftName { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public DateTime? Date { get; set; }
        public string WeekDayName { get; set; }
        public int? Workers { get; set; }
        public double ShiftHours { get; set; }

    }

}
