using TradeAPI.DataAccess.DataContext;
using TradeAPI.DataAccess.Models;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace TradeAPI.DataAccess.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Task<List<User>> GetAll()
        {
            return Task.FromResult(_context.Users.ToList());
        }

        public Task<User> GetById(int id)
        {
            return Task.FromResult(_context.Users.FirstOrDefault(user => user.Id.Equals(id)));
        }
    }
}
