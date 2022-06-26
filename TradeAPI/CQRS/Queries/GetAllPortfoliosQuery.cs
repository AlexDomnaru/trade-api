using DTO;
using MediatR;

namespace CQRS.Queries
{
    public class GetAllPortfoliosQuery : IRequest<List<Portfolio>>
    {
    }
}
