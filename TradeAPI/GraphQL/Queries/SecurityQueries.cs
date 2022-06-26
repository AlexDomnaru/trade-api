using CQRS.Queries;
using DTO;
using MediatR;

namespace GraphQL.Queries
{
    public class SecurityQueries
    {
        public async Task<List<Security>> GetAllSecurities([Service] IMediator mediator)
        {
            var securities = await mediator.Send(new GetAllSecuritiesQuery());
            return securities;
        }
    }
}
