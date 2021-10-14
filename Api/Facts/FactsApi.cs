using ApiTestFramework.Common;
using ApiTestFramework.Models.Facts;
using RestEase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiTestFramework.Api.Facts
{
    public class FactsApi
    {
        private readonly IFactsApi _factsApi;

        public FactsApi()
        {
            var requester = RequesterFactory.CreateRequester();
            _factsApi = RestClient.For<IFactsApi>(requester);
        }

        public async Task<List<FactViewModel>> GetRandomFactsAsync(string animalType, int numberOfFacts) 
            => await _factsApi.GetRandomAsync(animalType, numberOfFacts);

        public async Task<FactViewModel> GetFactAsync(string factId) => await _factsApi.GetFactAsync(factId);
    }
}
