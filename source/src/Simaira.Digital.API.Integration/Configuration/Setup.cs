using BoDi;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polly;
using Polly.Extensions.Http;
using Simaira.Digital.API.Integration.Common;
using Simaira.Digital.API.Integration.Common.Files;
using Simaira.Digital.API.Integration.TestsResponse;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Simaira.Digital.API.Integration.Configuration
{
    [Binding]
    public class Setup
    {
        private readonly IObjectContainer _objectContainer;
        private readonly TestContext _testContext;
        private readonly Endpoints _endpoints;
        private readonly IHttpClientFactory _httpClientFactory;

        [ClassInitialize]
        public static void SetUpBrowser(TestContext context)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Setup"/> class.
        /// </summary>
        /// <param name="objectContainer">The object container.</param>
        /// <param name="testContext">The test context.</param>
        /// <param name="endpoints">The endpoints instance.</param>
        public Setup(IObjectContainer objectContainer, TestContext testContext, Endpoints endpoints)
        {
            _objectContainer = objectContainer;
            _testContext = testContext;
            _endpoints = endpoints;

            var serviceCollection = new ServiceCollection();
            var policy = HttpPolicyExtensions
                .HandleTransientHttpError()
                .Or<IOException>()
                .Or<TaskCanceledException>()
                .Or<SocketException>()
                .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(4, retryAttempt)));
            serviceCollection
                .AddHttpClient(IHttpClientFactoryExtensions.Default, client => client.Timeout = TimeSpan.FromMinutes(5))
                .AddPolicyHandler(policy);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            _httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
        }


        [BeforeScenario]
        public async Task InitializeClientsAsync()
        {
            var environment = _testContext.GetEnvironment().ToLower();


            var fileClient = new FileClient();
            var configLoader = new ConfigurationLoader(fileClient);

            //var customerPortalConfig = configLoader.LoadConfiguration<APIConfig>("apiConfig.json", _testContext);
            //_endpoints.AppInsightInstrumentationKey = customerPortalConfig.AppInsightInstrumentationKey;

            var client = _httpClientFactory.CreateDefaultClient(new Uri("https://api-cloudhubcentral-st.ecolab.com/user-reg-and-alignment-int/api/b2c/v4/"));
            var customerPortalClient = _httpClientFactory.CreateClient(IHttpClientFactoryExtensions.Default);

            _objectContainer.RegisterInstanceAs<IAPIClientFactory>(new APIClientFactory(customerPortalClient, configLoader, _testContext));
            _objectContainer.RegisterInstanceAs(_httpClientFactory);


            _objectContainer.RegisterInstanceAs<IFileClient>(fileClient);
            _objectContainer.RegisterInstanceAs<IConfigurationLoader>(configLoader);
        }
    }
}
