using TradeAPI.DataAccess.DataContext;
using TradeAPI.DataAccess.Models;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace TradeAPI.DataAccess.Repositories.Implementations
{
    public class SecurityRepository : ISecurityRepository
    {
        private readonly ApplicationContext _context;

        public SecurityRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Task<List<Security>> GetAll()
        {
            return Task.FromResult(_context.Securities.ToList());
        }

        public Task<Security> GetById(int id)
        {
            return Task.FromResult(_context.Securities.FirstOrDefault(user => user.Id.Equals(id)));
        }

        public void UpdateSecurity(Security security)
        {
            var securityToUpdate = _context.Securities.Find(s => s.Id.Equals(security.Id));
            securityToUpdate = security;
        }
    }
}
