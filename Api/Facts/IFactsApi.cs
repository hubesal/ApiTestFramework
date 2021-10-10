using ApiTestFramework.Models;
using RestEase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiTestFramework.Api.Facts
{
    [BasePath("facts")]
    public interface IFactsApi
    {
        [Get("random")]
        public Task<Fact[]> GetRandomAsync(string animalType, int numberOfFacts);

        [Get("{id}")]
        public Task<Fact> GetFactAsync([Path("id")] string factId);
    }
}
