using DTO;
using MediatR;

namespace CQRS.Queries
{
    public class GetAllTradesForUserQuery : IRequest<List<Trade>>
    {
        public int UserId { get; set; }

        public GetAllTradesForUserQuery(int userId)
        {
            UserId = userId;
        }
    }
}
