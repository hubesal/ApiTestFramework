using ApiTestFramework.Api.Facts;

namespace ApiTestFramework.Api
{
    public class Api
    {
        public readonly FactsApi Facts;
        public readonly UsersApi Users;

        public Api()
        {
            Facts = new FactsApi();
            Users = new UsersApi();
        }
    }
}
