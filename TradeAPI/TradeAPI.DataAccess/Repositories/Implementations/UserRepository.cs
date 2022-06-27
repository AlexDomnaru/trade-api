using TradeAPI.DataAccess.DataContext;
using TradeAPI.DataAccess.Models;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace TradeAPI.DataAccess.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly IApplicationContext _context;

        public UserRepository(IApplicationContext context)
        {
            _context = context;
        }

        public Task<List<User>> GetAll()
        {
            return Task.FromResult(_context.Users.ToList());
        }

        public Task<List<User>> GetByIds(IEnumerable<int> ids)
        {
            return Task.FromResult(_context.Users.Where(user => ids.Contains(user.Id)).ToList());
        }

        public Task<User> GetById(int id)
        {
            return Task.FromResult(_context.Users.First(user => user.Id.Equals(id)));
        }
    }
}
