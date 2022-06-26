using DTO;
using MediatR;

namespace CQRS.Queries
{
    public class GetAllTradesQuery : IRequest<List<Trade>>
    {
    }
}
