using TradeAPI.DataAccess.DataContext;
using TradeAPI.DataAccess.Models;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace TradeAPI.DataAccess.Repositories.Implementations
{
    public class TradeRepository : ITradeRepository
    {
        private readonly IApplicationContext _context;

        public TradeRepository(IApplicationContext context)
        {
            _context = context;
        }

        public Task<List<Trade>> GetAll()
        {
            return Task.FromResult(_context.Trades.ToList());
        }

        public Task<List<Trade>> GetByUserIds(IEnumerable<int> ids)
        {
            return Task.FromResult(_context.Trades.Where(trade => ids.Contains(trade.UserId)).ToList());
        }

        public Task<Trade> GetById(int id)
        {
            return Task.FromResult(_context.Trades.First(trade => trade.Id.Equals(id)));
        }

        public Task<List<Trade>> GetByUserId(int userId)
        {
            return Task.FromResult(_context.Trades.Where(trade => trade.UserId.Equals(userId)).ToList());
        }

        public Task<bool> CreateTrade(Trade trade)
        {
            trade.Id = _context.Trades.Max(trade => trade.Id);
            _context.Trades.Add(trade);
            return Task.FromResult(true);
        }

        public Task<bool> DeleteTrade(int id)
        {
            _context.Trades.RemoveAll(trade => trade.Id.Equals(id));
            return Task.FromResult(true);
        }
    }
}
