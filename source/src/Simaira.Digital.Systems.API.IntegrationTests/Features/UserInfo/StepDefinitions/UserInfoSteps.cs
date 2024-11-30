namespace Simaira.Digital.Systems.IntegrationTests.Features.UserInfo.StepDefinitions
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
    using Simaira.Digital.Systems.IntegrationTests.Configuration;
    using Simaira.Digital.Systems.IntegrationTests.Models.TestsResponse;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TechTalk.SpecFlow;

    [Binding]
    public class UserInfoSteps : BaseSteps
    {
        private readonly IConfigurationLoader _configurationLoader;
        private readonly TestContext _testContext;
        private const string UserEmailListConfig = "userEmailList.json";

        public UserInfoSteps(
            IEcolabCustomerPortalClientFactory customerPortalClientFactory,
            ScenarioContext scenarioContext,
            Endpoints endpoints,
            IConfigurationLoader configurationLoader,
            TestContext testContext)
            : base(customerPortalClientFactory, scenarioContext, endpoints)
        {
            _configurationLoader = configurationLoader;
            _testContext = testContext;
        }


        [Given(@"The users already exist in CDM API")]
        public void SetUserEmailsInList(Table emailtable)
        {
            
            if (emailtable !=null && emailtable?.Rows.Count > 0)
            {
                foreach (var userInfo in emailtable?.Rows)
                {
                    _emails.Add(userInfo["Email"]);
                }
            }
            else
            {
                var emailInfo = _configurationLoader.LoadConfiguration<UserEmailList>(UserEmailListConfig, _testContext);
                foreach (var email in emailInfo.Emails)
                {
                    _emails.Add(email);
                }
            }
            

            AddToScenarioContext(OnboardedUsersEmailKey, _emails);
        }

        [Then(@"Get aligned CDM Sites and Accounts of Users from CDM API")]
        [Given(@"Set CDM Sites and Accounts of Users")]
        public async Task GetUsersCDMSitesAndAccountInfo()
        {
            var emails = GetFromScenarioContext(OnboardedUsersEmailKey);
            Assert.IsNotNull(emails);

            var emailList = (List<string>)emails;

            List<int> cdmSites = new List<int>();
            List<int> graphNodeSites = new List<int>();

            int customerKey = 0;
            foreach (var email in emailList)
            {
                string baseUrl = _endpoints.CustomerPortalEndpoint;
                RequestPayload payload = new RequestPayload();
                payload.PageContext = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.FeatureContext { Name = "userInfo", Component = "sites" };
                payload.UserInfo = new User { Email = email };
                var result = await _customerPortalClientFactory.HttpPostAsync<Response<IEnumerable<CDMAccountModel>>>(baseUrl, payload).ConfigureAwait(false);
                var customerKeys = result.Value.Select(cdm => cdm.CustomerKey).Distinct().ToList();
                customerKey = customerKeys.FirstOrDefault();
                cdmSites.AddRange(result.Value.Select( cdm => cdm.SiteKey));
                graphNodeSites.AddRange(result.Value.Select(cdm => cdm.GraphNodeSiteKey));
                Assert.AreEqual(200, result.StatusCode);
                // Assert.AreEqual(true, customerKeys.Count() == 1);
                Assert.AreEqual(true, result.Value.Count() > 0);
                AddToScenarioContext(email, result);
            }

            foreach (var email in emailList)
            {
                var response = GetFromScenarioContext(email);
                var cdmAccountModel = (Response<IEnumerable<CDMAccountModel>>)response;
                Assert.IsNotNull(cdmAccountModel);
            }

            AddToScenarioContext(CdmSitesKey, cdmSites);
            AddToScenarioContext(CustomerKey, customerKey);
            AddToScenarioContext(GraphNodeSiteKey, graphNodeSites);
        }

        [Then(@"Set User Accounts")]
        [Given(@"Set User Accounts")]
        public void SetUserAccounts(Table accountNumbers)
        {
            var accountNumberList = new List<string>();

            if (accountNumbers != null && accountNumbers?.Rows.Count > 0)
            {
                foreach (var accountInfo in accountNumbers?.Rows)
                {
                    accountNumberList.Add(accountInfo["AccountNumber"]);
                }

                AddToScenarioContext(AccountNumbersKey, accountNumberList);
            }
            else
            {
                var emails = GetFromScenarioContext(OnboardedUsersEmailKey);
                var emailList = (List<string>)emails;

                foreach (var email in emailList)
                {
                    var response = GetFromScenarioContext(email);
                    var cdmAccountModel = (Response<IEnumerable<CDMAccountModel>>)response;

                    accountNumberList = cdmAccountModel.Value.Select(cdm => cdm.AccountNumber).ToList();
                    AddToScenarioContext(AccountNumbersKey, accountNumberList);
                }

            }
        }


        [Then(@"Set h7Id Connected Accounts")]
        public void GetH7IdConnectdAccounts()
        {
            var accountNumberList = new List<string>();

            var response = GetFromScenarioContext(H7IdConnectedAccounts);
            var cdmAccountModel = (IEnumerable<ConnectedAccount>)response;

            accountNumberList = cdmAccountModel.Select(cdm => cdm.AccountNumber).ToList();
            AddToScenarioContext(AccountNumbersKey, accountNumberList);
        }

        [Then(@"Get Service Areas and Devices for Accounts")]
        [Given(@"Set Service Areas and Devices for Accounts")]
        public async Task GetServiceAreasAndDevicesInfo()
        {
            

            var response = GetFromScenarioContext(AccountNumbersKey);
            var accountNumberList = (List<string>)response;


            string baseUrl = _endpoints.CustomerPortalEndpoint;
            RequestPayload payload = new RequestPayload();
            payload.PageContext = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.FeatureContext { Name = "userInfo", Component = "serviceAreas" };
            payload.UserInfo = new User { AccountNumbers = accountNumberList, Features = new List<string> { "DM", "HH", "SS" } };
            var result = await _customerPortalClientFactory.HttpPostAsync<Response<IEnumerable<ServiceAreaDetail>>>(baseUrl, payload).ConfigureAwait(false);
            var dishMachineServiceAreas = result.Value.Where(serviceArea => serviceArea.Type == "DM");
            var handCareServiceAreas = result.Value.Where(serviceArea => serviceArea.Type == "HH" || serviceArea.Type == "HSO" || serviceArea.Type == "HSA");
            var sinkSurfaceServiceAreas = result.Value.Where(serviceArea => serviceArea.Type == "SS");
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual(true, result.Value.Count() > 0);
            AddToScenarioContext(ServiceAreasKey, result);
            AddToScenarioContext(DishMachineServiceAreasKey, dishMachineServiceAreas);
            AddToScenarioContext(HandCareServiceAreasKey, handCareServiceAreas);
            AddToScenarioContext(SinkSurfaceServiceAreasKey, sinkSurfaceServiceAreas);

        }


        [Then(@"Get Account Info")]
        [Given(@"Set Account Info")]
        public async Task GetAccountInfo(Table accountNumbers)
        {
            var accountNumberList = new List<string>();

            if (accountNumbers != null && accountNumbers?.Rows.Count > 0)
            {
                foreach (var accountInfo in accountNumbers?.Rows)
                {
                    accountNumberList.Add(accountInfo["AccountNumber"]);
                }
            }
            else
            {
                var contectAccountNumbers = GetFromScenarioContext(AccountNumbersKey);
                accountNumberList = (List<string>)contectAccountNumbers;               

            }

            List<AccountDetailsDto> accountDetails = new List<AccountDetailsDto>();
            string baseUrl = _endpoints.CustomerPortalEndpoint;
            foreach (var accountNumber in accountNumberList)
            {
                RequestPayload payload = new RequestPayload();
                payload.PageContext = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.FeatureContext { Name = "userInfo", Component = "account" };
                payload.UserInfo = new User { AccountNumbers = new List<string> { accountNumber } };
                var result = await _customerPortalClientFactory.HttpPostAsync<Response<IEnumerable<AccountDetailsDto>>>(baseUrl, payload).ConfigureAwait(false);
                Assert.AreEqual(200, result.StatusCode);
                Assert.AreEqual(true, result.Value.Count() > 0);
                accountDetails.AddRange(result.Value);
            }

            AddToScenarioContext(AccountInfoKey, accountDetails);

        }

        [Then(@"Get Account Details Info")]
        public async Task GetAccountDetailsInfo(Table accountNumbers)
        {
            var accountNumberList = new List<string>();

            if (accountNumbers != null && accountNumbers?.Rows.Count > 0)
            {
                foreach (var accountInfo in accountNumbers?.Rows)
                {
                    accountNumberList.Add(accountInfo["AccountNumber"]);
                }
            }
            else
            {
                var contectAccountNumbers = GetFromScenarioContext(AccountNumbersKey);
                accountNumberList = (List<string>)contectAccountNumbers;               

            }

            List<CDMAccountDetailsResponse> cdmAccountDetailsResponses = new List<CDMAccountDetailsResponse>();
            List<int> cdmSites = new List<int>();
            List<string> graphNodeSites = new List<string>();
            List<int> customerKeys = new List<int>();
            string baseUrl = _endpoints.CustomerPortalEndpoint;
            foreach (var accountNumber in accountNumberList)
            {
                RequestPayload payload = new RequestPayload();
                payload.PageContext = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.FeatureContext { Name = "userInfo", Component = "accountDetails" };
                payload.UserInfo = new User { AccountNumbers = new List<string> { accountNumber } };
                var result = await _customerPortalClientFactory.HttpPostAsync<Response<CDMAccountDetailsResponse>>(baseUrl, payload).ConfigureAwait(false);
                cdmSites.Add(result.Value.AccountDetails.SiteKey);
                graphNodeSites.Add(result.Value.AccountDetails.GraphNodeSiteKey);
                customerKeys.Add(result.Value.AccountDetails.CustomerKey);
                Assert.AreEqual(200, result.StatusCode);
                cdmAccountDetailsResponses.Add(result.Value);
            }

            Assert.AreEqual(1, customerKeys.Distinct().Count());
            AddToScenarioContext(AccountDetailsKey, cdmAccountDetailsResponses);
            AddToScenarioContext(CdmSitesKey, cdmSites);
            AddToScenarioContext(GraphNodeSiteKey, graphNodeSites);
            AddToScenarioContext(CustomerKey, customerKeys.FirstOrDefault());

        }


        [Then(@"Get Location Details")]
        public async Task GetLocationDetails(Table siteKeys)
        {
            var siteKeysList = new List<string>();
            var graphNodeSiteKeysList = new List<string>();

            if (siteKeys != null && siteKeys?.Rows.Count > 0)
            {
                foreach (var site in siteKeys?.Rows)
                {
                    siteKeysList.Add((site["SiteKey"]));
                }
            }
            else
            {
                var cdmSites = GetFromScenarioContext(CdmSitesKey);

                if (cdmSites != null)
                {
                    var temp = (List<int>)cdmSites;
                    siteKeysList = temp.Select(site => site.ToString()).ToList();
                }

                var graphNodeSites = GetFromScenarioContext(GraphNodeSiteKey);

                if (graphNodeSites != null)
                {
                    if (graphNodeSites is List<int>)
                    {
                        var temp = (List<int>)graphNodeSites;
                        graphNodeSiteKeysList = temp.Select(site => site.ToString()).ToList();
                    }
                    else
                    {
                        var temp = (List<string>)graphNodeSites;
                        graphNodeSiteKeysList = temp.Select(site => site).ToList();
                    }
                    
                }

            }

            string baseUrl = _endpoints.CustomerPortalEndpoint;
            RequestPayload payload = new RequestPayload();
            payload.PageContext = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.FeatureContext { Name = "userInfo", Component = "locationDetails" };
            payload.UserInfo = new User { SiteKeys = siteKeysList, GraphNodeSiteKeys = graphNodeSiteKeysList };
            var result = await _customerPortalClientFactory.HttpPostAsync<Response<IEnumerable<LocationDetail>>>(baseUrl, payload).ConfigureAwait(false);
            Assert.AreEqual(200, result.StatusCode);

            AddToScenarioContext(LocationsKey, result);

        }


        [Given(@"The H7Id already exist")]
        public void Addh7IdForConnectedAccounts(Table h7Ids)
        {

            string h7IdValue = string.Empty;
            foreach (var h7Id in h7Ids?.Rows)
            {
                h7IdValue = h7Id["H7Id"];
            }

            AddToScenarioContext(H7Id, h7IdValue);
        }


        [Then(@"Get Connected Accounts for H7Id Info")]
        public async Task GetConnectedAccountsAsync()
        {
            var h7IdObj = GetFromScenarioContext(H7Id);
            var h7Id = (string)h7IdObj;
            string baseUrl = _endpoints.CustomerPortalEndpoint;
            RequestPayload payload = new RequestPayload();
            payload.PageContext = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.FeatureContext { Name = "userInfo", Component = "connectedAccounts" };
            payload.UserInfo = new User { H7Id = h7Id };
            var result = await _customerPortalClientFactory.HttpPostAsync<Response<IEnumerable<ConnectedAccount>>>(baseUrl, payload).ConfigureAwait(false);
            Assert.AreEqual(200, result.StatusCode);
            AddToScenarioContext(H7IdConnectedAccounts, result.Value);

        }

        [Then(@"Get Customer Goal")]
        public async Task GetCustomerGoalForESSUserAsync()
        {
            var customerKey = (int)GetFromScenarioContext(CustomerKey);
            string baseUrl = _endpoints.CustomerPortalEndpoint;
            RequestPayload payload = new RequestPayload();
            payload.PageContext = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.FeatureContext { Name = "userInfo", Component = "goals" };
            payload.UserInfo = new User { CustomerKey = customerKey };
            var result = await _customerPortalClientFactory.HttpPostAsync<Response<CustomerGoal>>(baseUrl, payload).ConfigureAwait(false);
            Assert.AreEqual(200, result.StatusCode);
            AddToScenarioContext(CustomerGoalKey, result.Value);

        }


        [Given(@"Set Ecolab Features")]
        public void SetEcolabFeatures(Table features)
        {

            List<string> featureList = new List<string>();
            foreach (var feature in features?.Rows)
            {
                featureList.Add(feature["Feature"]);
            }

            AddToScenarioContext(EcolabFeaturesKey, featureList);
        }

        [Then(@"Get Customer BenchMarking")]
        public async Task GetCustomerBenchMarkingAsync()
        {
            var customerKey = (int)GetFromScenarioContext(CustomerKey);
            var features = (List<string>)GetFromScenarioContext(EcolabFeaturesKey);
            var accountNumbers = (List<string>)GetFromScenarioContext(AccountNumbersKey);

            string baseUrl = _endpoints.CustomerPortalEndpoint;
            RequestPayload payload = new RequestPayload();
            payload.PageContext = new Ecolab.Simaira.Digital.CustomerPortal.Model.RequestModels.FeatureContext { Name = "overview", Component = "benchMarking" };
            payload.Overview = new Overview { AccountNumbers = accountNumbers, CustomerKey = customerKey, Features = features };
            var result = await _customerPortalClientFactory.HttpPostAsync<Response<BenchmarkingResponseDto>>(baseUrl, payload).ConfigureAwait(false);
            Assert.AreEqual(200, result.StatusCode);
            AddToScenarioContext(CustomerGoalKey, result.Value);

        }
    }
}
