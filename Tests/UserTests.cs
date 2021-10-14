using FluentAssertions;
using System.Threading.Tasks;
using Xunit;

namespace ApiTestFramework.Tests
{
    public class UserTests
    {
        private readonly Api.Api _api;

        public UserTests()
        {
            _api = new Api.Api();
        }

        [Fact]
        public async Task GivenUserId_GetUserInfo_ShouldNotBeNull()
        {
            var response = await _api.Users.GetUserInfoAsync("me");

            response.Should().NotBeNull();
        }
    }
}
