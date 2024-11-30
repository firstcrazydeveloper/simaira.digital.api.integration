namespace Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels
{
    public interface IRequestPayload : IPageContext, IUser, IInsight, IPurchase, IWidget, IOverview, IUserHierarchy, ISinkSurface, IHandCare, IDishMachine, IOverviewPulseCheck
    {
    }
}
