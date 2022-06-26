using CQRS.Queries;
using DTO;
using MediatR;

namespace GraphQL.Queries
{
    public class TradeQueries
    {
        public async Task<List<Trade>> GetAllTrades([Service] IMediator mediator)
        {
            var trades = await mediator.Send(new GetAllTradesQuery());
            return trades;
        }

        public async Task<List<Trade>> GetTradesByUserId([Service] IMediator mediator, int id)
        {
            var trades = await mediator.Send(new GetAllTradesForUserQuery(id));
            return trades;
        }
    }
}
