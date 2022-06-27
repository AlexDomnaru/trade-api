using TradeAPI.DataAccess.Models;

namespace TradeAPI.DataAccess.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();
        Task<List<User>> GetByIds(IEnumerable<int> ids);
        Task<User> GetById(int id);
    }
}
