using CQRS.Queries;
using DTO;
using MediatR;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace CQRS.Handlers
{
    public class GetAllSecuritiesQueryHandler : IRequestHandler<GetAllSecuritiesQuery, List<Security>>
    {
        private readonly ISecurityRepository _securityRepository;

        public GetAllSecuritiesQueryHandler(ISecurityRepository securityRepository)
        {
            _securityRepository = securityRepository;
        }

        public async Task<List<Security>> Handle(GetAllSecuritiesQuery request, CancellationToken cancellationToken)
        {
            var securities = (await _securityRepository.GetAll()).Select(security => new Security(security.Id, security.SecurityCode, security.MarketPrice)).ToList();
            return securities;
        }
    }
}
