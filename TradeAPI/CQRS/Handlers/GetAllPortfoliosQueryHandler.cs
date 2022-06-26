using CQRS.Queries;
using DTO;
using MediatR;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace CQRS.Handlers
{
    public class GetAllPortfoliosQueryHandler : IRequestHandler<GetAllPortfoliosQuery, List<Portfolio>>
    {
        private readonly ISecurityRepository _securityRepository;
        private readonly ITradeRepository _tradeRepository;
        private readonly IUserRepository _userRepository;

        public GetAllPortfoliosQueryHandler(ISecurityRepository securityRepository, ITradeRepository tradeRepository, IUserRepository userRepository)
        {
            _securityRepository = securityRepository;
            _tradeRepository = tradeRepository;
            _userRepository = userRepository;
        }

        public async Task<List<Portfolio>> Handle(GetAllPortfoliosQuery request, CancellationToken cancellationToken)
        {
            var portfolios = new List<Portfolio>();

            var users = await _userRepository.GetAll();
            var securities = await _securityRepository.GetAll();
            foreach (var user in users)
            {
                var trades = await _tradeRepository.GetByUserId(user.Id);
                var totalMarketValue = 0.0;
                var totalPurchaseValue = 0.0;
                foreach (var trade in trades)
                {
                    var security = securities.First(security => security.Id.Equals(trade.SecurityId));
                    totalMarketValue += security.MarketPrice * trade.Quantity;
                    totalPurchaseValue += trade.TradePrice * trade.Quantity;
                }
                var userPortfolio = new Portfolio(new User(user.Id, user.Name), totalPurchaseValue, totalMarketValue);
                portfolios.Add(userPortfolio);
            }

            return portfolios;
        }
    }
}
