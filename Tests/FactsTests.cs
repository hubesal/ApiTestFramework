using ApiTestFramework.Api.Facts;
using FluentAssertions;
using FluentAssertions.Execution;
using System.Threading.Tasks;
using Xunit;

namespace ApiTestFramework.Tests
{
    public class FactsTests
    {
        private readonly FactsApi _factsApi;
        public FactsTests()
        {
            _factsApi = new FactsApi();
        }

        [Fact]
        public async Task GivenCatAsAnimal_GetTwoRandomFacts_ShouldReturnFactsForCat()
        {
           var response = await _factsApi.GetRandomFactsAsync("cat", 3);

            using (new AssertionScope())
            {
                response.Should().NotBeNull();
                response.Length.Should().Be(3);
            }
        }
    }
}
