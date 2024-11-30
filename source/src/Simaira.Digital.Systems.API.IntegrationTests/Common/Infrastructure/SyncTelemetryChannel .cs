namespace Simaira.Digital.Systems.IntegrationTests.Common.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using Microsoft.ApplicationInsights.Channel;
    using Microsoft.ApplicationInsights.Extensibility.Implementation;

    public class SyncTelemetryChannel : ITelemetryChannel
    {
        private Uri endpoint = new Uri("https://dc.services.visualstudio.com/v2/track");

        public bool? DeveloperMode { get; set; }

        public string EndpointAddress { get; set; }

        public void Dispose() { }

        public void Flush() { }

        public void Send(ITelemetry item)
        {
            byte[] json = JsonSerializer.Serialize(new List<ITelemetry>() { item }, true);
            Transmission transimission = new Transmission(endpoint, json, "application/x-json-stream", JsonSerializer.CompressionType);
            var t = transimission.SendAsync();
            t.Wait();
        }
    }
}
