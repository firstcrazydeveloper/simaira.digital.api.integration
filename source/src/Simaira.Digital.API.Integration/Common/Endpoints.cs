namespace Simaira.Digital.API.Integration.Common
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Simaira.Digital.API.Integration.Configuration;

    public class Endpoints
    {
        private readonly string _environment;

        public Endpoints(TestContext testContext)
        {
            _environment = testContext.GetEnvironment().ToLower();
        }

        public string CustomerPortalEndpoint => $"https://ins-e3d-appservice-001-{GetEnvironment()}.azurewebsites.net/api/v1/ProcessManagement";

        public string AppInsightInstrumentationKey { get; set; }

        public string CosmosEndpoint { get; set; }

        public string GetEnvironment()
        {
            switch (_environment)
            {
                case "dev":
                    {
                        return "d";
                    }
                case "sit":
                    {
                        return "q";
                    }
                case "uat":
                    {
                        return "s";
                    }
                case "prod":
                    {
                        return "p";
                    }
                default:
                    {
                        return "d";
                    }
            }
        }

        public string GetAppInsightInstrumentationKey()
        {
            switch (_environment)
            {
                case "dev":
                    {
                        return "2a7412a1-b3c2-4760-b93b-c05778162754";
                    }
                case "sit":
                    {
                        return "2a7412a1-b3c2-4760-b93b-c05778162754";
                    }
                case "uat":
                    {
                        return "2a7412a1-b3c2-4760-b93b-c05778162754";
                    }
                case "prod":
                    {
                        return "2a7412a1-b3c2-4760-b93b-c05778162754";
                    }
                default:
                    {
                        return "2a7412a1-b3c2-4760-b93b-c05778162754";
                    }
            }
        }
    }
}
