namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Enums
{
    public enum PageContext
    {
        userInfo,
        overview,
        overviewPulseCheck,
        insight,
        purchase,
        dishMachine,
        handCare,
        sinkSurface,
        userHierarchy,
    }

    public enum UserInfo
    {
        sites,
        account,
        accountDetails,
        dishMachineServiceArea,
        handCareServiceArea,
        sinkSurfaceServiceArea,
        goals,
        alignment,
        serviceAreas,
        locationDetails,
        connectedAccounts,
    }

    public enum UserHierarchy
    {
        hierarchyLevel,
        customerHierarchy,
        connectedAccountsHierarchyDetails,
    }

    public enum Overview
    {
        benchMarking,
    }

    public enum OverviewPulseCheck
    {
        pulseCheck,
    }

    public enum Insight
    {
        bubbles,
        alerts,
    }

    public enum Purchase
    {
        unitOptimalProducts,
        corporateOptimalProducts,
        outstandingCategories,
        purchaseCategoriesCompliance,
        purchaseOverallPerformanceByCategories,
        purchaseHasProgram,
    }

    public enum DishMachine
    {
        dishMachineOverallPerformance,
        shiftLevelPerformance,
        dishRackUsagesTrend,
        dishTempratureTrend,
        dishAlertTrend,
        dishAlertActivityTracking,
        benchMarking,
    }

    public enum HandCare
    {
        handSoapOverallPerformance,       
        handSoapShiftLevelPerformance,
        handSoapDispenserLevelPerformance,
        handSoapShiftDetailsPerformance,
        handSanitizerOverallPerformance,
        handSanitizerShiftLevelPerformance,
        handSanitizerDispenserLevelPerformance,
        handSanitizerDetailsPerformance,
        benchMarking,
    }

    public enum SinkSurface
    {
        sinkSurfaceOverallPerformance,
        sinkSurfaceShiftWisePerformance,
        sinkSurfaceDispenserWisePerformance,
    }
}
