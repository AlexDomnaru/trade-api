using CQRS.Commands;
using MediatR;
using TradeAPI.DataAccess.Models;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace CQRS.Handlers
{
    public class CreateTradeCommandHandler : IRequestHandler<CreateTradeCommand, bool>
    {
        private readonly ITradeRepository _tradeRepository;
        private readonly ISecurityRepository _securityRepository;

        public CreateTradeCommandHandler(ITradeRepository tradeRepository, ISecurityRepository securityRepository)
        {
            _tradeRepository = tradeRepository;
            _securityRepository = securityRepository;
        }

        public async Task<bool> Handle(CreateTradeCommand request, CancellationToken cancellationToken)
        {
            var security = await _securityRepository.GetById(request.SecurityId);
            var trade = new Trade(security.MarketPrice, request.Quantity, DateTime.Today, request.SecurityId, request.UserId);
            return await _tradeRepository.CreateTrade(trade);
        }
    }
}
