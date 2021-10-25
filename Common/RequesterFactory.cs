using ApiTestFramework.Providers;
using RestEase;
using RestEase.Implementation;
using System;
using System.Net.Http;

namespace ApiTestFramework.Common
{
    public static class RequesterFactory
    {
        public static IRequester CreateRequester()
        {
            var baseUrl = ConfigurationProvider.Read().BaseUrl;
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl),
                Timeout = TimeSpan.FromMinutes(2)
            };

            return new Requester(httpClient);
        }
    }
}
