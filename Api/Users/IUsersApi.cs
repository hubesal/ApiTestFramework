using ApiTestFramework.Models.Users;
using RestEase;
using System.Threading.Tasks;

namespace ApiTestFramework.Api.Users
{
    [BasePath("users")]
    public interface IUsersApi
    {
        [Get("{id}")]
        public Task<UserViewModel> GetUsersAsync([Path("id")] string userId);
    }
}
