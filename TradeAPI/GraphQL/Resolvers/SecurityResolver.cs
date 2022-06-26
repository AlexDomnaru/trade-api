using HotChocolate.Resolvers;
using TradeAPI.DataAccess.Models;
using TradeAPI.DataAccess.Repositories.Interfaces;

namespace GraphQL.Resolvers
{
    public class SecurityResolver
    {

        private readonly ISecurityRepository _securityRepository;

        public SecurityResolver(ISecurityRepository securityRepository)
        {
            _securityRepository = securityRepository;
        }

        public async Task<Security> GetSecurity(int id, IResolverContext ctx)
        {
            return await _securityRepository.GetById(id);
        }
        public async Task<List<Security>> GetSecurities(IResolverContext ctx)
        {
            return await _securityRepository.GetAll();
        }
    }
}
