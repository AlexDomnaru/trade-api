using CQRS.Commands;
using MediatR;

namespace GraphQL.Mutations
{
    public class SecurityMutations
    {
        public async Task<bool> UpdateSecurityMarketPrice([Service] IMediator mediator, int id, float newPrice)
        {
            return await mediator.Send(new UpdateSecurityCommand(id, newPrice));
        }
    }
}
