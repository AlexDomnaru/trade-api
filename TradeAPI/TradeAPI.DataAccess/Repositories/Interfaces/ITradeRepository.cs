using TradeAPI.DataAccess.Models;

namespace TradeAPI.DataAccess.Repositories.Interfaces
{
    public interface ITradeRepository
    {
        Task<List<Trade>> GetAll();
        Task<Trade> GetById(int id);
        void CreateTrade(Trade trade);
    }
}
