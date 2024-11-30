namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Ecolab.Simaira.Digital.CustomerPortal.Model.System.ShiftModels;
    using global::System;
    using global::System.ComponentModel.DataAnnotations;

    public class ServiceAreaShiftModel
    {
        [Required]
        public int CustomerKey { get; set; }
        [Required]
        public string CdmsiteKey { get; set; }
        [Required]
        [Range(-24, 24)]
        public double? TimeZone { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        public string AccountName { get; set; }
        [Required]
        public string ServiceAreaId { get; set; }
        [Required]
        public string ServiceAreaName { get; set; }
        [Required]
        [CustomDayNameValidation]
        public string ShiftDayOfWeek { get; set; }
        [Required]
        public int? ShiftEnumeration { get; set; }
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