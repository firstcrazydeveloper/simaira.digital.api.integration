namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using Ecolab.Simaira.Digital.CustomerPortal.Model.System.ShiftModels;
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using static Ecolab.Simaira.Digital.CustomerPortal.Model.Constants;

    public abstract class EventShiftBase
    {
        public string DeviceId { get; set; }
        public DateTime EventUTCTime { get; set; }
        public DateTime EventLocalTime { get; set; }
        public string ShiftName { get; set; }
        public int ShiftEnumeration { get; set; }
        public int NumberOfWorker { get; set; }
        public TimeSpan ShiftHours { get; set; }
        public DateTime ShiftWiseEventDate { get; set; }
        public void ProcessShift(List<ShiftFlatModel> shifts)
        {
            var shiftsDayWise = shifts.SelectMany(o => o.ShiftDays.Select(p =>
                 new
                 {
                     o.NumberOfWorkers,
                     o.ShiftEnumeration,
                     o.ShiftName,
                     StartTime = o.StartTime.Value,
                     EndTime = o.StartTime > o.EndTime ? new TimeSpan(0, 23, 59, 59, 999) : o.EndTime.Value,
                     EndTimeTemp = o.EndTime.Value,
                     numberOfWorker = o.NumberOfWorkers,
                     DayOfWeek = p,
                     IsOvernight = o.StartTime > o.EndTime,
                     ReduceOneDay = false
                 }
            )).ToList();

            // Generate additional shift for overnight
            var overNightShifts = shiftsDayWise.Where(o => o.IsOvernight)
                .Select(o => new
                {
                    o.NumberOfWorkers,
                    o.ShiftEnumeration,
                    o.ShiftName,
                    StartTime = o.StartTime, // set StartTime as 00 hour
                    EndTime = o.EndTimeTemp,
                    EndTimeTemp = TimeSpan.Zero,
                    numberOfWorker = o.NumberOfWorkers,
                    DayOfWeek = GetNextDayOfWeek(o.DayOfWeek), // pick next DayOfWeek
                    IsOvernight = true,
                    ReduceOneDay = true
                }).ToList();
            shiftsDayWise.AddRange(overNightShifts);

            var shift = shiftsDayWise.FirstOrDefault(p =>
                 p.DayOfWeek == ShiftDayOfWeek(EventLocalTime) &&
                 EventLocalTime.TimeOfDay > p.StartTime &&
                 EventLocalTime.TimeOfDay < p.EndTime);
            if (shift != null)
            {
                ShiftWiseEventDate = shift.ReduceOneDay ? EventLocalTime.AddDays(-1).Date : EventLocalTime.Date;
                ShiftName = shift.ShiftName;
                ShiftEnumeration = shift.ShiftEnumeration;
                NumberOfWorker = shift.NumberOfWorkers == null ? 0 : (int)shift.NumberOfWorkers;
                ShiftHours = shift.EndTime - shift.StartTime;
            }
        }
    }
}
