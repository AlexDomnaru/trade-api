using CQRS.Queries;
using DTO;
using MediatR;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace CQRS.Handlers
{
    public class GetAllTradesForUserQueryHandler : IRequestHandler<GetAllTradesForUserQuery, List<Trade>>
    {
        private readonly ISecurityRepository _securityRepository;
        private readonly ITradeRepository _tradeRepository;
        private readonly IUserRepository _userRepository;

        public GetAllTradesForUserQueryHandler(ISecurityRepository securityRepository, ITradeRepository tradeRepository, IUserRepository userRepository)
        {
            _securityRepository = securityRepository;
            _tradeRepository = tradeRepository;
            _userRepository = userRepository;
        }

        public async Task<List<Trade>> Handle(GetAllTradesForUserQuery request, CancellationToken cancellationToken)
        {
            var trades = new List<Trade>();

            var databaseTrades = await _tradeRepository.GetByUserId(request.UserId);
            foreach (var trade in databaseTrades)
            {
                var user = await _userRepository.GetById(trade.UserId);
                var security = await _securityRepository.GetById(trade.SecurityId);

                trades.Add(new Trade(trade.Id, trade.TradePrice, trade.Quantity, trade.Date,
                    new Security(security.Id, security.SecurityCode, security.MarketPrice),
                    new User(user.Id, user.Name)
                    ));
            }

            return trades;
        }
    }
}
