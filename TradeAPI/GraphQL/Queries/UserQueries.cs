using CQRS.Queries;
using DTO;
using MediatR;

namespace GraphQL.Queries
{
    public class UserQueries
    {
        public async Task<List<User>> GetAllUsers([Service] IMediator mediator)
        {
            var users = await mediator.Send(new GetAllUsersQuery());
            return users;
        }
    }
}
