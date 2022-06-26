using HotChocolate.Resolvers;
using TradeAPI.DataAccess.Models;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace GraphQL.Resolvers
{
    public class UserResolver
    {
        private readonly IUserRepository _userRepository;

        public UserResolver(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUser(int id, IResolverContext ctx)
        {
            return await _userRepository.GetById(id);
        }
        public async Task<List<User>> GetUsers(IResolverContext ctx)
        {
            return await _userRepository.GetAll();
        }
    }
}
