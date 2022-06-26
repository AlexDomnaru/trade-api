using TradeAPI.DataAccess.DataContext;
using TradeAPI.DataAccess.Models;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace TradeAPI.DataAccess.Repositories.Implementations
{
    public class TradeRepository : ITradeRepository
    {
        private readonly ApplicationContext _context;

        public TradeRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Task<List<Trade>> GetAll()
        {
            return Task.FromResult(_context.Trades.ToList());
        }

        public Task<Trade> GetById(int id)
        {
            return Task.FromResult(_context.Trades.FirstOrDefault(trade => trade.Id.Equals(id)));
        }

        public void CreateTrade(Trade trade)
        {
            _context.Trades.Add(trade);
        }
    }
}
