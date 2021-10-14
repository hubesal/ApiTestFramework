using ApiTestFramework.Models.Facts;
using RestEase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiTestFramework.Api.Facts
{
    [BasePath("facts")]
    public interface IFactsApi
    {
        [Get("random")]
        public Task<List<FactViewModel>> GetRandomAsync(string animal_type, int amount);

        [Get("{id}")]
        public Task<FactViewModel> GetFactAsync([Path("id")] string factId);
    }
}
