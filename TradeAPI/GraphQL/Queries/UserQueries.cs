using TradeAPI.DataAccess.Models;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace GraphQL.Queries
{
    public class UserQueries
    {
        public async Task<List<User>> GetAllUsers([Service] IUserRepository userRepository)
        {
            var users = await userRepository.GetAll();
            return users;
        }

        public async Task<User> GetUserById([Service] IUserRepository userRepository, int id)
        {
            var user = await userRepository.GetById(id);
            return user;
        }
    }
}
