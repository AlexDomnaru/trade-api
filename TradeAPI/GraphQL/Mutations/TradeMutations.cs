using CQRS.Commands;
using MediatR;

namespace GraphQL.Mutations
{
    public class TradeMutations
    {
        public async Task<bool> CreateTrade([Service] IMediator mediator,
             int quantity, int securityId, int userId)
        {
            return await mediator.Send(new CreateTradeCommand(quantity, securityId, userId));
        }

        public async Task<bool> DeleteTrade([Service] IMediator mediator,
             int id)
        {
            return await mediator.Send(new DeleteTradeCommand(id));
        }
    }
}
