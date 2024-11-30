namespace Simaira.Digital.Systems.IntegrationTests.Common
{
    using Simaira.Digital.Systems.IntegrationTests.Common.Infrastructure;
    using Microsoft.ApplicationInsights;
    using Microsoft.ApplicationInsights.Extensibility;
    using System;

    public class TelemetryClientService<T> : ITelemetryClientService<T> where T : class
    {
        private readonly TelemetryClient _telemetryClient;
        private readonly Endpoints _endpoints;
        public TelemetryClientService(Endpoints endpoints)
        {
            _endpoints = endpoints;
            var telemetryConfiguration = TelemetryConfiguration.CreateDefault();
            telemetryConfiguration.TelemetryChannel = new SyncTelemetryChannel();
            telemetryConfiguration.ConnectionString = $"InstrumentationKey={_endpoints.AppInsightInstrumentationKey};IngestionEndpoint=https://eastus2-3.in.applicationinsights.azure.com/;LiveEndpoint=https://eastus2.livediagnostics.monitor.azure.com/";
            _telemetryClient = new TelemetryClient(telemetryConfiguration);
            
        }

        public void LogError(Exception ex, string message)
        {
            _telemetryClient.TrackException(ex);
        }

        public void LogError(string message, params object[] args)
        {
            _telemetryClient.TrackException(new Exception(string.Format(message, args)));
        }

        public void LogInformation(string message, params object[] args)
        {
            _telemetryClient.TrackTrace(string.Format(message, args));
        }

        public void LogTrace(string message)
        {
            _telemetryClient.TrackTrace(message);
        }
    }   
}
