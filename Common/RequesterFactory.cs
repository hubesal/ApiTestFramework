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
            var baseUrl = "https://cat-fact.herokuapp.com";
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl),
                Timeout = TimeSpan.FromMinutes(2)
            };

            return new Requester(httpClient);
        }
    }
}
