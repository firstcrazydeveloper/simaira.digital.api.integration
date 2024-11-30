namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System.ShiftModels
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;

    public class ShiftFlatModel
    {
        public string ShiftDayOfWeek { get; set; }
        public int ShiftEnumeration { get; set; }
        public string ShiftName { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int? NumberOfWorkers { get; set; }
        public double? TimeZone { get; set; }
        public bool TimeZoneCalculated { get; set; }
        public List<string> ShiftDays
        {
            get
            {
                return ShiftDayOfWeek?.TrimStart('(').TrimEnd(')').Split(",").ToList() ?? new List<string>();
            }
        }

        public double ShiftHours
        {
            get
            {
                TimeSpan t1 = TimeSpan.Parse(StartTime.ToString());
                TimeSpan t2 = TimeSpan.Parse(EndTime.ToString());
                double _24h = (new TimeSpan(24, 0, 0)).TotalMilliseconds;
                double diff = t2.TotalMilliseconds - t1.TotalMilliseconds;
                if (diff < 0)
                {
                    diff += _24h;
                }

                var shiftDuration = TimeSpan.FromMilliseconds(diff).TotalHours;
                return shiftDuration;
            }
        }
    }
}
