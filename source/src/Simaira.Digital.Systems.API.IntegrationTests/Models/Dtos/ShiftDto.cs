namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos
{
    public class ShiftDto
    {
        public int CustomerKey { get; set; }
        public string CdmsiteKey { get; set; }
        public double? TimeZone { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string ServiceAreaId { get; set; }
        public string ServiceAreaName { get; set; }
        public string ShiftDayOfWeek { get; set; }
        public int ShiftEnumeration { get; set; }
        public string ShiftName { get; set; }
    }
}
