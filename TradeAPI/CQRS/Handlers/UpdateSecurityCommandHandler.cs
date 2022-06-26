using CQRS.Commands;
using MediatR;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace CQRS.Handlers
{
    public class UpdateSecurityCommandHandler : IRequestHandler<UpdateSecurityCommand, bool>
    {
        private readonly ISecurityRepository _securityRepository;

        public UpdateSecurityCommandHandler(ISecurityRepository securityRepository)
        {
            _securityRepository = securityRepository;
        }

        public async Task<bool> Handle(UpdateSecurityCommand request, CancellationToken cancellationToken)
        {
            var security = await _securityRepository.GetById(request.SecurityId);
            security.MarketPrice = request.NewPrice;
            return await _securityRepository.UpdateSecurity(security);
        }
    }
}
