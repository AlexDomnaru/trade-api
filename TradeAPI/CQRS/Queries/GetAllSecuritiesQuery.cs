using DTO;
using MediatR;

namespace CQRS.Queries
{
    public class GetAllSecuritiesQuery : IRequest<List<Security>>
    {
    }
}
