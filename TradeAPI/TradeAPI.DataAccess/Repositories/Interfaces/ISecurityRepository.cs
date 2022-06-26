using TradeAPI.DataAccess.Models;

namespace TradeAPI.DataAccess.Repositories.Interfaces
{
    public interface ISecurityRepository
    {
        Task<List<Security>> GetAll();
        Task<Security> GetById(int id);
        Task<bool> UpdateSecurity(Security security);
    }
}
