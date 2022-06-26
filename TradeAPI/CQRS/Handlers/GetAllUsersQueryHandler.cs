using CQRS.Queries;
using DTO;
using MediatR;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace CQRS.Handlers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<User>>
    {
        private readonly IUserRepository _userRepository;

        public GetAllUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = (await _userRepository.GetAll()).Select(user => new User(user.Id, user.Name)).ToList();
            return users;
        }
    }
}
