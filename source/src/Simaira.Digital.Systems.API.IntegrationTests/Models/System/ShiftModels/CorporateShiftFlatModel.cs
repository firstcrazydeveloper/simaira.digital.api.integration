namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System.ShiftModels
{
    public class CorporateShiftFlatModel
    {
        public int CustomerKey { get; set; }
        public int ShiftDayOfWeek { get; set; }
        public int ShiftEnumeration { get; set; }
        public string ShiftName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int? NumberOfWorkers { get; set; }
        public bool? IsActive { get; set; }
    }
}
