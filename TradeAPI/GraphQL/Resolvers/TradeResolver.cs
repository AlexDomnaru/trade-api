using HotChocolate.Resolvers;
using TradeAPI.DataAccess.Models;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace GraphQL.Resolvers
{
    public class TradeResolver
    {
        private readonly ITradeRepository _tradeRepository;

        public TradeResolver(ITradeRepository tradeRepository)
        {
            _tradeRepository = tradeRepository;
        }

        public async Task<Trade> GetTrade(int id, IResolverContext ctx)
        {
            return await _tradeRepository.GetById(id);
        }
        public async Task<List<Trade>> GetTrades(IResolverContext ctx)
        {
            return await _tradeRepository.GetAll();
        }
    }
}
