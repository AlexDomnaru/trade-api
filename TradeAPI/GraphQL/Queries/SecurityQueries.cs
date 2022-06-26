using TradeAPI.DataAccess.Models;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace GraphQL.Queries
{
    public class SecurityQueries
    {
        public async Task<List<Security>> GetAllSecurities([Service] ISecurityRepository securityRepository)
        {
            var securities = await securityRepository.GetAll();
            return securities;
        }

        public async Task<Security> GetSecurityById([Service] ISecurityRepository securityRepository, int id)
        {
            var security = await securityRepository.GetById(id);
            return security;
        }
    }
}
