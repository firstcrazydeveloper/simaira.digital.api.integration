namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System
{
    public class DMEventModel : EventShiftBase
    {
        public string SiteIdentifier { get; set; }

        public int GoodRacksPercent { get; set; }

        public int RackCount { get; set; }

        public int AllAlertSum { get; set; }
    }
}
