using DTO;
using MediatR;

namespace CQRS.Queries
{
    public class GetAllUsersQuery : IRequest<List<User>>
    {
    }
}
