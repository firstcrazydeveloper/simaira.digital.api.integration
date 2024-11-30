namespace Simaira.Digital.Systems.IntegrationTests.Common
{
    using System;

    public interface ITelemetryClientService<T> where T: class
    {
        void LogError(string message, params object[] args);
        void LogError(Exception ex, string message);
        void LogInformation(string message, params object[] args);
        void LogTrace(string message);

    }
}
