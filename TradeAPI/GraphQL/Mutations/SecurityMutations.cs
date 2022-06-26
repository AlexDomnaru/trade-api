using TradeAPI.DataAccess.Models;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace GraphQL.Mutations
{
    public class SecurityMutations
    {
        public async Task<Security> UpdateSecurityMarketPrice([Service] ISecurityRepository securityRepository, int id, double newPrice)
        {
            var security = await securityRepository.GetById(id);
            security.MarketPrice = newPrice;
            securityRepository.UpdateSecurity(security);
            return security;
        }
    }
}
