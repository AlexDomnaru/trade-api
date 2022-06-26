using CQRS.Queries;
using DTO;
using MediatR;

namespace GraphQL.Queries
{
    public class PortfolioQueries
    {
        public async Task<List<Portfolio>> GetAllPortfolios([Service] IMediator mediator)
        {
            var portfolios = await mediator.Send(new GetAllPortfoliosQuery());
            return portfolios;
        }
    }
}
