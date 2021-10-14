using FluentAssertions;
using FluentAssertions.Execution;
using System;
using System.Threading.Tasks;
using Xunit;

namespace ApiTestFramework.Tests
{
    public class FactsTests
    {
        private readonly Api.Api _api;
        private readonly Random _random;

        public FactsTests()
        {
            _api = new Api.Api();
            _random = new Random();
        }

        [Fact]
        public async Task GivenCatAsAnimal_GetThreeRandomFacts_ShouldReturnFactsForCat()
        {
           var response = await _api.Facts.GetRandomFactsAsync("cat", 3);

            using (new AssertionScope())
            {
                response.Should().NotBeNull();
                response.Count.Should().Be(3);
            }
        }

        [Fact]
        public async Task GivenHorseAsAnimal_GetFactId_ShouldReturnAFact()
        {
            var listOfFactIds = new string[] { "5b7a07a32048fd0014e9d8b2", "5b12d729cf4b960d5eb02eba",
                                        "5b7a06b22048fd0014e9d8a2", "5b7a057c2048fd0014e9d89a" };
            var randomFactIndex = _random.Next(0, listOfFactIds.Length - 1);
            var randomFactId = listOfFactIds[randomFactIndex];
            var response = await _api.Facts.GetFactAsync(randomFactId);

            response.Should().NotBeNull();
        }
    }
}
