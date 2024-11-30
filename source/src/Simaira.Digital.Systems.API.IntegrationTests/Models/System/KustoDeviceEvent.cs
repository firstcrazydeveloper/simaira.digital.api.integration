namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    using global::System;
    public class KustoDeviceEvent : EventShiftBase
    {
        public string SiteIdentifier { get; set; }

        public string CdmSiteKey { get; set; }

        public int GoodRacksPercent { get; set; }

        public int RackCount { get; set; }

        public int AllAlertSum { get; set; }
    }
}
