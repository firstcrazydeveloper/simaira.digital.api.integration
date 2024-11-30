namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Ecolab.Simaira.Digital.CustomerPortal.Model.System.ShiftModels;
    using global::System;
    using global::System.ComponentModel.DataAnnotations;

    public class CorporateShiftModel
    {
        [Required]
        public int CustomerKey { get; set; }
        [Required]
        [CustomDayNameValidation]
        public string ShiftDayOfWeek { get; set; }
        public int? ShiftEnumeration { get; set; }
        [Required]
        public string ShiftName { get; set; }
        [Required]
        [DataType(DataType.Time)]
        [Range(typeof(TimeSpan), "00:00:00", "23:59:59")]
        public string StartTime { get; set; }
        [Required]
        [DataType(DataType.Time)]
        [Range(typeof(TimeSpan), "00:00:00", "23:59:59")]
        public string EndTime { get; set; }
        public int? NumberOfWorkers { get; set; }
        public bool? IsActive { get; set; }
    }
}
