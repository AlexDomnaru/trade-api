using TradeAPI.DataAccess.Models;

namespace TradeAPI.DataAccess.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();
        Task<User> GetById(int id);
    }
}
