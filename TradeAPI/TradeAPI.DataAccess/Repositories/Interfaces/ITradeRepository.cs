using TradeAPI.DataAccess.Models;

namespace TradeAPI.DataAccess.Repositories.Interfaces
{
    public interface ITradeRepository
    {
        Task<List<Trade>> GetAll();
        Task<Trade> GetById(int id);
        Task<List<Trade>> GetByUserId(int userId);
        Task<bool> CreateTrade(Trade trade);
        Task<bool> DeleteTrade(int id);
    }
}
