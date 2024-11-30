namespace Simaira.Digital.Systems.IntegrationTests.Features
{
    using System.Collections.Generic;
    using Simaira.Digital.Systems.IntegrationTests.Common;
    using TechTalk.SpecFlow;

    public class BaseSteps : Steps
    {
        protected const string H7Id = "h7Id";
        protected const string H7IdConnectedAccounts = "h7IdConnectedAccounts";
        protected const string ServiceAreasKey = "serviceAreasKey";
        protected const string EcolabFeaturesKey = "ecolabFeaturesKey";
        protected const string SinkSurfaceOverviewWidgetKey = "sinkSurfaceOverviewWidgetKey";
        protected const string SinkSurfacePulseCheckKey = "sinkSurfacePulseCheckKey";
        protected const string DishMachineOverviewWidgetKey = "dishMachineOverviewWidgetKey";
        protected const string DishMachinePulseCheckKey = "dishMachinePulseCheckKey";
        protected const string AccountNumbersKey = "accountNumbersKey";
        protected const string AccountInfoKey = "accountInfoKey";
        protected const string AccountDetailsKey = "accountDetailsKey";
        protected const string CdmSitesKey = "cdmSitesKey";
        protected const string CustomerKey = "customerKey";
        protected const string CustomerGoalKey = "customerGoalKey";
        protected const string GraphNodeSiteKey = "graphNodeSiteKey";
        protected const string LocationsKey = "locationsKey";
        protected const string DishMachineServiceAreasKey = "dishMachineServiceAreasKey";
        protected const string HandCareServiceAreasKey = "handCareServiceAreasKey";
        protected const string SinkSurfaceServiceAreasKey = "sinkSurfaceServiceAreasKey";
        protected const string OnboardedUsersEmailKey = "OnboardedUsersEmailKey";
        protected const string BrandStandardUnitLevelOptimalProductsKey = "brandStandardUnitLevelOptimalProductsKey";
        protected const string BrandStandardOutstandingCategoriesKey = "brandStandardOutstandingCategoriesKey";
        protected const string BrandStandardCorporateOptimalProductsKey = "brandStandardCorporateOptimalProductsKey";
        protected const string BrandStandardPurchaseCategoriesComplianceKey = "brandStandardPurchaseCategoriesComplianceKey";
        protected const string BrandStandardPurchaseOverallPerformanceByCategoriesKey = "brandStandardPurchaseOverallPerformanceByCategoriesKey";

        protected readonly ScenarioContext _scenarioContext;
        protected readonly IEcolabCustomerPortalClientFactory _customerPortalClientFactory;
        protected readonly Endpoints _endpoints;
        protected readonly List<string> _emails;

        public BaseSteps(IEcolabCustomerPortalClientFactory customerPortalClientFactory, ScenarioContext scenarioContext, Endpoints endpoints)
        {
            _customerPortalClientFactory = customerPortalClientFactory;
            _endpoints = endpoints;
            _scenarioContext = scenarioContext;
            _emails = new List<string>();
        }


        protected void AddToScenarioContext<T>(string key, T value)
        {
            if (_scenarioContext.ContainsKey(key))
            {
                _scenarioContext[key] = value;
            }
            else
            {
                _scenarioContext.Add(key, value);
            }
        }

        protected object GetFromScenarioContext(string key)
        {
            if (_scenarioContext.ContainsKey(key))
            {
                return _scenarioContext[key];
            }

            return null;
        }
    }
}
