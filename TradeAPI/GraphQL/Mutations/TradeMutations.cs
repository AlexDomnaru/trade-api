using TradeAPI.DataAccess.Models;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace GraphQL.Mutations
{
    public class TradeMutations
    {
        public async Task<Trade> CreateTrade([Service] ITradeRepository tradeRepository, 
            [Service] ISecurityRepository securityRepository,
            int buyerId, int securityId, int quantity)
        {
            var security = await securityRepository.GetById(securityId);
            var trade = new Trade(security.MarketPrice, quantity, DateTime.Now, securityId, buyerId);
            tradeRepository.CreateTrade(trade);
            return trade;
        }
    }
}
