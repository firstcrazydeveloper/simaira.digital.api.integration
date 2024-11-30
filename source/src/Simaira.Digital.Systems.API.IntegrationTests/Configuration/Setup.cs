namespace Simaira.Digital.Systems.IntegrationTests.Configuration
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Net.Sockets;
    using System.Threading.Tasks;
    using BoDi;
    using Simaira.Digital.Systems.IntegrationTests.Common;
    using Simaira.Digital.Systems.IntegrationTests.Models.TestsResponse;
    using Microsoft.Azure.Cosmos;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Polly;
    using Polly.Extensions.Http;
    using TechTalk.SpecFlow;

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

            var customerPortalConfig = configLoader.LoadConfiguration<CustomerPortalConfig>("customerPortalConfig.json", _testContext);
            _endpoints.AppInsightInstrumentationKey = customerPortalConfig.AppInsightInstrumentationKey;


            _objectContainer.RegisterInstanceAs<IFileClient>(fileClient);
            _objectContainer.RegisterInstanceAs<IConfigurationLoader>(configLoader);

            var client = _httpClientFactory.CreateDefaultClient(new Uri("https://api-cloudhubcentral-st.ecolab.com/user-reg-and-alignment-int/api/b2c/v4/"));
            var customerPortalClient = _httpClientFactory.CreateClient(IHttpClientFactoryExtensions.Default);
            _objectContainer.RegisterInstanceAs<CDMAPIConnector>(new CDMAPIConnector(client));
            _objectContainer.RegisterInstanceAs<IEcolabCustomerPortalClientFactory>(new EcolabCustomerPortalClientFactory(customerPortalClient, configLoader, _testContext));
            _objectContainer.RegisterInstanceAs(_httpClientFactory);

            CosmosClientOptions options = new CosmosClientOptions() { AllowBulkExecution = true, ConnectionMode = ConnectionMode.Direct };
            options.MaxRetryAttemptsOnRateLimitedRequests = 30;

            _objectContainer.RegisterInstanceAs<ITelemetryClientService<ScenarioTest>>(new TelemetryClientService<ScenarioTest>(_endpoints));
            var cosmosClient = new CosmosClient(customerPortalConfig.CosmosEndpoint, options);
            Database database = await cosmosClient.CreateDatabaseIfNotExistsAsync(id: "Simaira.DigitalAPISystemTest");
            Container container = await database.CreateContainerIfNotExistsAsync(id: "APIIntegrationTest", partitionKeyPath: "/status", throughput: 400);
            CosmosDbContainerFactory cosmosDbContainerFactory = new CosmosDbContainerFactory(cosmosClient, "Simaira.DigitalAPISystemTest");
            _objectContainer.RegisterInstanceAs<ICosmosDbContainerFactory>(cosmosDbContainerFactory);
            _objectContainer.RegisterInstanceAs<IDocumentRepository<ScenarioTest>>(new DocumentRepository<ScenarioTest>(cosmosDbContainerFactory));
            CosmosDbContainer cosmosDbContainer = new CosmosDbContainer(cosmosClient, "Simaira.DigitalAPISystemTest", "APIIntegrationTest");
            _objectContainer.RegisterInstanceAs<ICosmosDbContainer>(cosmosDbContainer);

            
        }

    }
}
