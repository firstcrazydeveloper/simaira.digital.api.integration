namespace Simaira.Digital.API.Integration.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public static class TestContextExtensions
    {
        private const string _defaultEnvironment = "DEV";
        private const string _environmentVariable = "TEST_ENVIRONMENT";
        private static List<string> _supportedEnvironments = new List<string>() { "DEV", "SIT", "UAT", "PROD", "DEMO" };

        public static string GetEnvironment(this TestContext context)
        {
            string environment = string.Empty;

            if (RunsettingsContainEnvironment(context))
            {
                environment = GetEnvironmentFromRunsettings(context);
            }
            else if (IsEnvironmentEnvironmentVariableDefined())
            {
                environment = GetEnvironmentFromEnvironmentVariable();
            }
            else
            {
                environment = GetDefaultEnvironment();
            }

            if (!IsEnvironmentSupported(environment))
            {
                throw new ArgumentException($"The environment {environment} is no supported");
            }

            return environment.ToUpper();
        }

        public static string GetFullyQualifiedResourcePath(this TestContext context, string resourceName, bool useGlobalConfig = false)
        {
            try
            {
                var resource = typeof(TestContextExtensions).Assembly.GetManifestResourceNames().First(res =>
                {
                    var feature = context.GetFeatureName();
                    if (useGlobalConfig)
                    {
                        feature = "Global";
                    }

                    var environment = context.GetEnvironment();

                    return res.Contains($"Configuration.{environment}.{resourceName}");
                });

                return resource;
            }
            catch (InvalidOperationException)
            {
                Assert.Fail($"Fully qualified resource path could not be assembled for {resourceName}");
                return "NOT_FOUND";
            }
        }

        private static string GetDefaultEnvironment()
        {
            return _defaultEnvironment;
        }

        private static string GetEnvironmentFromEnvironmentVariable()
        {
            string environment = Environment.GetEnvironmentVariable(_environmentVariable);
            return environment;
        }

        private static string GetEnvironmentFromRunsettings(TestContext context)
        {
            string environment = context.Properties["environment"].ToString();
            return environment;
        }

        private static string GetFeatureName(this TestContext context)
        {
            var fqClassName = context.FullyQualifiedTestClassName;

            if (fqClassName.Contains("SimairaDigital.IoT.Integration.SystemTests.Platform.Examples"))
            {
                return "Examples";
            }

            var substring = context.FullyQualifiedTestClassName.Replace("SimairaDigital.IoT.Integration.SystemTests.Platform.Features.", string.Empty);
            int dotLocation = substring.IndexOf('.');
            var result = substring.Substring(0, dotLocation);

            return result;
        }

        private static bool IsEnvironmentEnvironmentVariableDefined()
        {
            var variables = Environment.GetEnvironmentVariables();
            var isEnvironmentVariableDefined = variables.Contains(_environmentVariable);
            return isEnvironmentVariableDefined;
        }

        private static bool IsEnvironmentSupported(string environment)
        {
            var isEnvironmentSupported = _supportedEnvironments.Contains(environment.ToUpper());
            return isEnvironmentSupported;
        }

        private static bool RunsettingsContainEnvironment(TestContext context)
        {
            var runsettingsContainEnvironment = context.Properties.Contains("environment");
            return runsettingsContainEnvironment;
        }
    }
}
