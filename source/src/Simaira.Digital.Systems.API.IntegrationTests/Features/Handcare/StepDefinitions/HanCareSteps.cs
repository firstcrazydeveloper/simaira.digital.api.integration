namespace Simaira.Digital.Systems.IntegrationTests.Features.Handcare.StepDefinitions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos;
    using Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels;
    using Ecolab.Simaira.Digital.CustomerPortal.Model.ResponseModels;
    using Ecolab.Simaira.Digital.CustomerPortal.Model.System;
    using Simaira.Digital.Systems.IntegrationTests.Common;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TechTalk.SpecFlow;

    [Binding]
    public class HanCareSteps : BaseSteps
    {
        public HanCareSteps(IEcolabCustomerPortalClientFactory customerPortalClientFactory, ScenarioContext scenarioContext, Endpoints endpoints)
            : base(customerPortalClientFactory, scenarioContext, endpoints)
        {
        }

        [Given(@"Get aligned CDM Sites and Accounts for '(.*)' from CDM API for Hand Care")]
        public async Task GetUsersCDMSitesAndAccountInfoAsync(string email)
        {
            _emails.Add(email);
            AddToScenarioContext(OnboardedUsersEmailKey, _emails);
            List<int> cdmSites = new List<int>();
            List<int> graphNodeSites = new List<int>();

            int customerKey = 0;

            string baseUrl = _endpoints.CustomerPortalEndpoint;
            RequestPayload payload = new RequestPayload();
            payload.PageContext = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.FeatureContext { Name = "userInfo", Component = "sites" };
            payload.UserInfo = new User { Email = email };
            var result = await _customerPortalClientFactory.HttpPostAsync<Response<IEnumerable<CDMAccountModel>>>(baseUrl, payload).ConfigureAwait(false);
            var customerKeys = result.Value.Select(cdm => cdm.CustomerKey).Distinct().ToList();
            customerKey = customerKeys.FirstOrDefault();
            cdmSites.AddRange(result.Value.Select(cdm => cdm.SiteKey));
            graphNodeSites.AddRange(result.Value.Select(cdm => cdm.GraphNodeSiteKey));
            Assert.AreEqual(200, result.StatusCode);
            // Assert.AreEqual(true, customerKeys.Count() == 1);
            Assert.AreEqual(true, result.Value.Count() > 0);
            AddToScenarioContext(email, result);

            AddToScenarioContext(CdmSitesKey, cdmSites);
            AddToScenarioContext(CustomerKey, customerKey);
            AddToScenarioContext(GraphNodeSiteKey, graphNodeSites);
        }

        [Given(@"Hand Care Overall Performance Request Payload")]
        public void CraeteHandCareOverallPerformancePayload()
        {
            var customerKey = (int)GetFromScenarioContext(CustomerKey);
            OverviewWidget overviewWidget = new OverviewWidget();
            overviewWidget.Feature = "SS";
            overviewWidget.IsPulseCheck = true;
            overviewWidget.Days = 14;
            overviewWidget.CustomerKey = customerKey;
            overviewWidget.ChartRequests = new List<ChartRequest>();

            var emails = GetFromScenarioContext(OnboardedUsersEmailKey);
            var emailList = (List<string>)emails;

            var sinkSurfaces = (IEnumerable<ServiceAreaDetail>)GetFromScenarioContext(SinkSurfaceServiceAreasKey);

            var chartRequests = new List<ChartRequest>();
            foreach (var email in emailList)
            {
                var cmdAccounts = (Response<IEnumerable<CDMAccountModel>>)GetFromScenarioContext(email);

                foreach (var cdmAccount in cmdAccounts.Value)
                {
                    ChartRequest chartRequest = new ChartRequest();
                    chartRequest.Name = "CDMSite";
                    chartRequest.Value = Convert.ToString(cdmAccount.SiteKey);
                    var serviceAreas = new List<Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.ServiceArea>();
                    var filter = sinkSurfaces.Where(data => data.AccountNumber == cdmAccount.AccountNumber).ToList();
                    foreach (var data in filter)
                    {
                        var serviceArea = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.ServiceArea();
                        serviceArea.AccountNumber = data.AccountNumber;
                        serviceArea.ServiceAreaId = data.Value;
                        serviceArea.Devices = new Dictionary<string, string>();

                        foreach (var device in data.Machines)
                        {
                            serviceArea.Devices.Add(device.Value, device.Label);
                        }

                        serviceAreas.Add(serviceArea);
                    }

                    chartRequest.ServiceAreas = serviceAreas;
                    if (serviceAreas.Count > 0)
                    {
                        chartRequests.Add(chartRequest);
                    }
                }
            }

            overviewWidget.ChartRequests = chartRequests;
            AddToScenarioContext(SinkSurfaceOverviewWidgetKey, overviewWidget);
        }

        [Then(@"Get Hand Care Overall Performance for Pulse Check '(.*)'")]
        public async Task GetHandCareOverallPerformanceAsync(bool isPulseCheck)
        {
            var response = (OverviewWidget)GetFromScenarioContext(SinkSurfaceOverviewWidgetKey);
            response.IsPulseCheck = isPulseCheck;

            string baseUrl = _endpoints.CustomerPortalEndpoint;
            RequestPayload payload = new RequestPayload();
            payload.PageContext = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.FeatureContext { Name = "sinkSurface", Component = "sinkSurfaceOverallPerformance" };
            payload.SinkSurface = response;
            var result = await _customerPortalClientFactory.HttpPostAsync<Response<IEnumerable<OverallPerformanceWithPercResponseDto>>>(baseUrl, payload).ConfigureAwait(false);
            Assert.AreEqual(200, result.StatusCode);
            AddToScenarioContext(SinkSurfacePulseCheckKey, result);

            if (isPulseCheck)
            {
                Assert.AreEqual("pulsecheck", result.Value.First().DeviceGroupName);
                Assert.AreEqual("overview", result.Value.First().DeviceGroupValue);
                Assert.AreEqual(true, result.Value.Count() == 1);

            }
            else
            {
                Assert.IsTrue(response.ChartRequests.Count() >= result.Value.Count());
            }


        }
    }
}
