namespace Simaira.Digital.Systems.IntegrationTests.Features.BrandStandard.StepDefinitions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos;
    using Ecolab.Simaira.Digital.CustomerPortal.Model.Process;
    using Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels;
    using Ecolab.Simaira.Digital.CustomerPortal.Model.ResponseModels;
    using Ecolab.Simaira.Digital.CustomerPortal.Model.System;
    using Simaira.Digital.Systems.IntegrationTests.Common;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TechTalk.SpecFlow;

    [Binding]
    public class BrandStandardStep : BaseSteps
    {
        public BrandStandardStep(IEcolabCustomerPortalClientFactory customerPortalClientFactory, ScenarioContext scenarioContext, Endpoints endpoints)
            : base(customerPortalClientFactory, scenarioContext, endpoints)
        {
        }

        [Given(@"Get aligned CDM Sites and Accounts for '(.*)' from CDM API for Brand Standard")]
        public async Task GetUsersCDMSitesAndAccountInfoAsync(string email)
        {
            _emails.Add(email);
            AddToScenarioContext(OnboardedUsersEmailKey, _emails);
            List<int> cdmSites = new List<int>();
            List<int> graphNodeSites = new List<int>();

            string baseUrl = _endpoints.CustomerPortalEndpoint;
            RequestPayload payload = new RequestPayload();
            payload.PageContext = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.FeatureContext { Name = "userInfo", Component = "sites" };
            payload.UserInfo = new User { Email = email };
            var result = await _customerPortalClientFactory.HttpPostAsync<Response<IEnumerable<CDMAccountModel>>>(baseUrl, payload).ConfigureAwait(false);
            cdmSites.AddRange(result.Value.Select(cdm => cdm.SiteKey));
            graphNodeSites.AddRange(result.Value.Select(cdm => cdm.GraphNodeSiteKey));
            Assert.AreEqual(200, result.StatusCode);
            // Assert.AreEqual(true, customerKeys.Count() == 1);
            Assert.AreEqual(true, result.Value.Count() > 0);
            AddToScenarioContext(email, result);

            AddToScenarioContext(CdmSitesKey, cdmSites);
            AddToScenarioContext(GraphNodeSiteKey, graphNodeSites);
        }


        [Then(@"Get Brand Standard UnitOptimalProducts")]
        public async Task GetBrandStandardUnitOptimalProductsAsync()
        {
            Purchase purchase = new Purchase();
            var graphNodeSites = (IEnumerable<int>)GetFromScenarioContext(GraphNodeSiteKey);
            var sites = (IEnumerable<int>)GetFromScenarioContext(CdmSitesKey);
            purchase.GraphNodeSiteKeys = graphNodeSites.Select(key => Convert.ToString(key));
            purchase.SiteKeys = sites.Select(key => Convert.ToString(key));

            string baseUrl = _endpoints.CustomerPortalEndpoint;
            RequestPayload payload = new RequestPayload();
            payload.PageContext = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.FeatureContext { Name = "purchase", Component = "unitOptimalProducts" };
            payload.Purchase = purchase;
            var result = await _customerPortalClientFactory.HttpPostAsync<Response<IEnumerable<OptimalProductResponse>>>(baseUrl, payload).ConfigureAwait(false);
            Assert.AreEqual(200, result.StatusCode);
            AddToScenarioContext(BrandStandardUnitLevelOptimalProductsKey, result);
        }


        [Then(@"Get Brand Standard OutstandingCategories")]
        public async Task GetBrandStandardOutstandingCategoriesAsync()
        {
            Purchase purchase = new Purchase();
            var graphNodeSites = (IEnumerable<int>)GetFromScenarioContext(GraphNodeSiteKey);
            var sites = (IEnumerable<int>)GetFromScenarioContext(CdmSitesKey);
            purchase.GraphNodeSiteKeys = graphNodeSites.Select(key => Convert.ToString(key));
            purchase.SiteKeys = sites.Select(key => Convert.ToString(key));

            string baseUrl = _endpoints.CustomerPortalEndpoint;
            RequestPayload payload = new RequestPayload();
            payload.PageContext = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.FeatureContext { Name = "purchase", Component = "outstandingCategories" };
            payload.Purchase = purchase;
            var result = await _customerPortalClientFactory.HttpPostAsync<Response<IEnumerable<CategoryModelResponse>>>(baseUrl, payload).ConfigureAwait(false);
            Assert.AreEqual(200, result.StatusCode);
            AddToScenarioContext(BrandStandardOutstandingCategoriesKey, result);
        }


        [Then(@"Get Brand Standard CorporateOptimalProducts")]
        public async Task GetBrandStandardCorporateOptimalProductsAsync()
        {
            Purchase purchase = new Purchase();
            var graphNodeSites = (IEnumerable<int>)GetFromScenarioContext(GraphNodeSiteKey);
            var sites = (IEnumerable<int>)GetFromScenarioContext(CdmSitesKey);
            purchase.GraphNodeSiteKeys = graphNodeSites.Select(key => Convert.ToString(key));
            purchase.SiteKeys = sites.Select(key => Convert.ToString(key));

            string baseUrl = _endpoints.CustomerPortalEndpoint;
            RequestPayload payload = new RequestPayload();
            payload.PageContext = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.FeatureContext { Name = "purchase", Component = "corporateOptimalProducts" };
            payload.Purchase = purchase;
            var result = await _customerPortalClientFactory.HttpPostAsync<Response<OptimalProductsComplianceRatio>>(baseUrl, payload).ConfigureAwait(false);
            Assert.AreEqual(200, result.StatusCode);
            AddToScenarioContext(BrandStandardCorporateOptimalProductsKey, result);
        }


        [Then(@"Get Brand Standard Purchase Categories Compliance")]
        public async Task GetBrandStandardPurchaseCategoriesComplianceAsync()
        {
            Purchase purchase = new Purchase();
            var graphNodeSites = (IEnumerable<int>)GetFromScenarioContext(GraphNodeSiteKey);
            var sites = (IEnumerable<int>)GetFromScenarioContext(CdmSitesKey);
            purchase.GraphNodeSiteKeys = graphNodeSites.Select(key => Convert.ToString(key));
            purchase.SiteKeys = sites.Select(key => Convert.ToString(key));

            string baseUrl = _endpoints.CustomerPortalEndpoint;
            RequestPayload payload = new RequestPayload();
            payload.PageContext = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.FeatureContext { Name = "purchase", Component = "purchaseCategoriesCompliance" };
            payload.Purchase = purchase;
            var result = await _customerPortalClientFactory.HttpPostAsync<Response<IEnumerable<BrandStandardPurchasingCategory>>>(baseUrl, payload).ConfigureAwait(false);
            Assert.AreEqual(200, result.StatusCode);
            AddToScenarioContext(BrandStandardPurchaseCategoriesComplianceKey, result);
        }


        [Then(@"Get Brand Standard Purchase OverallPerformance By Categories")]
        public async Task GetBrandStandardPurchaseOverallPerformanceByCategoriesAsync()
        {
            Purchase purchase = new Purchase();
            var graphNodeSites = (IEnumerable<int>)GetFromScenarioContext(GraphNodeSiteKey);
            var sites = (IEnumerable<int>)GetFromScenarioContext(CdmSitesKey);
            purchase.GraphNodeSiteKeys = graphNodeSites.Select(key => Convert.ToString(key));
            purchase.SiteKeys = sites.Select(key => Convert.ToString(key));

            string baseUrl = _endpoints.CustomerPortalEndpoint;
            RequestPayload payload = new RequestPayload();
            payload.PageContext = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.FeatureContext { Name = "purchase", Component = "purchaseOverallPerformanceByCategories" };
            payload.Purchase = purchase;
            var result = await _customerPortalClientFactory.HttpPostAsync<Response<PurchasingOverallperformanceResponse>>(baseUrl, payload).ConfigureAwait(false);
            Assert.AreEqual(200, result.StatusCode);
            AddToScenarioContext(BrandStandardPurchaseOverallPerformanceByCategoriesKey, result);
        }
    }
}
