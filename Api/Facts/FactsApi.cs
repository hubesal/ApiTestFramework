using ApiTestFramework.Common;
using ApiTestFramework.Models;
using RestEase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiTestFramework.Api.Facts
{
    public class FactsApi
    {
        public IFactsApi factsApi;

        public FactsApi()
        {
            var requester = RequesterFactory.CreateRequester();
            factsApi = RestClient.For<IFactsApi>(requester);
        }

        public async Task<List<FactViewModel>> GetRandomFactsAsync(string animalType, int numberOfFacts) 
            => await factsApi.GetRandomAsync(animalType, numberOfFacts);

        public async Task<FactViewModel> GetFactAsync(string factId) => await factsApi.GetFactAsync(factId);
    }
}
