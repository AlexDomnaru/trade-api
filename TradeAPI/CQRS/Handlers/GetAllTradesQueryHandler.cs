using CQRS.Queries;
using DTO;
using MediatR;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace CQRS.Handlers
{
    public class GetAllTradesQueryHandler : IRequestHandler<GetAllTradesQuery, List<Trade>>
    {
        private readonly ISecurityRepository _securityRepository;
        private readonly ITradeRepository _tradeRepository;
        private readonly IUserRepository _userRepository;

        public GetAllTradesQueryHandler(ISecurityRepository securityRepository, ITradeRepository tradeRepository, IUserRepository userRepository)
        {
            _securityRepository = securityRepository;
            _tradeRepository = tradeRepository;
            _userRepository = userRepository;
        }

        public async Task<List<Trade>> Handle(GetAllTradesQuery request, CancellationToken cancellationToken)
        {
            var trades = new List<Trade>();

            var databaseTrades = await _tradeRepository.GetAll();

            var userIds = databaseTrades.Select(trade => trade.UserId).ToList();
            var usersDictionary = (await _userRepository.GetByIds(userIds)).ToDictionary(user => user.Id, user => user);

            var securityIds = databaseTrades.Select(trade => trade.SecurityId);
            var securitiesDictionary = (await _securityRepository.GetByIds(securityIds)).ToDictionary(security => security.Id, security => security);

            foreach (var trade in databaseTrades)
            {
                var user = usersDictionary[trade.UserId];
                var security = securitiesDictionary[trade.SecurityId];

                trades.Add(new Trade(trade.Id, trade.TradePrice, trade.Quantity, trade.Date,
                    new Security(security.Id, security.SecurityCode, security.MarketPrice),
                    new User(user.Id, user.Name)
                    ));
            }

            return trades;
        }
    }
}
