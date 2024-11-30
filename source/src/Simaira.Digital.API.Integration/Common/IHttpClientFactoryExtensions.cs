namespace Simaira.Digital.API.Integration.Common
{
    using System;
    using System.Net.Http;

    public static class IHttpClientFactoryExtensions
    {
        public const string Default = "default";

        public static HttpClient CreateDefaultClient(this IHttpClientFactory httpClientFactory, Uri uri)
        {
            return CreateClient(httpClientFactory, Default, uri);
        }

        public static HttpClient CreateClient(this IHttpClientFactory httpClientFactory, string name, Uri uri)
        {
            var client = httpClientFactory.CreateClient(name);
            client.BaseAddress = uri;
            return client;
        }
    }
}
