namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    using global::System.Collections.Generic;

    public interface IOverviewPulseCheck
    {
        IEnumerable<OverviewWidget> OverviewPulseCheck { get; set; }
    }
}
