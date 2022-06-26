using CQRS.Commands;
using MediatR;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace CQRS.Handlers
{
    public class DeleteTradeCommandHandler : IRequestHandler<DeleteTradeCommand, bool>
    {
        private readonly ITradeRepository _tradeRepository;

        public DeleteTradeCommandHandler(ITradeRepository tradeRepository)
        {
            _tradeRepository = tradeRepository;
        }

        public async Task<bool> Handle(DeleteTradeCommand request, CancellationToken cancellationToken)
        {
            return await _tradeRepository.DeleteTrade(request.Id);
        }
    }
}
