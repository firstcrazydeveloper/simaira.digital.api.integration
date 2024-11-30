namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System.Converters
{
    using EnsureThat;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using System;

    public static class KustoDeviceEventConverter
    {
        public static HHEventModel ToHHEventModel(this KustoDeviceEvent kustoEvent)
        {
            EnsureArg.IsNotNull(kustoEvent, nameof(kustoEvent));

            var hhEventModel = new HHEventModel
            {
                DeviceId = kustoEvent.DeviceId,
                EventLocalTime = kustoEvent.EventLocalTime,
                EventUTCTime = kustoEvent.EventUTCTime,
                ShiftWiseEventDate = kustoEvent.ShiftWiseEventDate,
                NumberOfWorker = kustoEvent.NumberOfWorker,
                ShiftEnumeration = kustoEvent.ShiftEnumeration,
                ShiftHours = kustoEvent.ShiftHours,
                ShiftName = kustoEvent.ShiftName,
                SiteIdentifier = kustoEvent.SiteIdentifier,
            };

            return hhEventModel;
        }

        public static IEnumerable<HHEventModel> ToHHEventModelList(this IEnumerable<KustoDeviceEvent> kustoEvents)
        {
            return kustoEvents?.Select(hhevent => hhevent.ToHHEventModel()).ToList();
        }

        public static DMEventModel ToDMEventModel(this KustoDeviceEvent kustoEvent)
        {
            EnsureArg.IsNotNull(kustoEvent, nameof(kustoEvent));

            var hhEventModel = new DMEventModel
            {
                DeviceId = kustoEvent.DeviceId,
                EventLocalTime = kustoEvent.EventLocalTime,
                EventUTCTime = kustoEvent.EventUTCTime,
                ShiftWiseEventDate = kustoEvent.ShiftWiseEventDate,
                NumberOfWorker = kustoEvent.NumberOfWorker,
                ShiftEnumeration = kustoEvent.ShiftEnumeration,
                ShiftHours = kustoEvent.ShiftHours,
                ShiftName = kustoEvent.ShiftName,
                AllAlertSum = kustoEvent.AllAlertSum,
                SiteIdentifier = kustoEvent.SiteIdentifier,
                GoodRacksPercent = kustoEvent.GoodRacksPercent,
                RackCount = kustoEvent.RackCount,
            };

            return hhEventModel;
        }

        public static IEnumerable<DMEventModel> ToDMEventModelList(this IEnumerable<KustoDeviceEvent> kustoEvents)
        {
            return kustoEvents?.Select(dmevent => dmevent.ToDMEventModel()).ToList();
        }
    }
}
