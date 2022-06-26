using TradeAPI.DataAccess.Models;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace GraphQL.Queries
{
    public class TradeQueries
    {
        public async Task<List<Trade>> GetAllTrades([Service] ITradeRepository tradeRepository)
        {
            var trades = await tradeRepository.GetAll();
            return trades;
        }

        public async Task<Trade> GetTradeById([Service] ITradeRepository tradeRepository, int id)
        {
            var trades = await tradeRepository.GetById(id);
            return trades;
        }
    }
}
