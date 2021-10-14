using ApiTestFramework.Api.Users;
using ApiTestFramework.Common;
using ApiTestFramework.Models.Users;
using RestEase;
using System.Threading.Tasks;

namespace ApiTestFramework.Api
{
    public class UsersApi
    {
        private readonly IUsersApi _usersApi;
        public UsersApi()
        {
            var requester = RequesterFactory.CreateRequester();
            _usersApi = RestClient.For<IUsersApi>(requester);
        }

        public async Task<UserViewModel> GetUserInfoAsync(string userId) 
            => await _usersApi.GetUsersAsync(userId);
    }
}