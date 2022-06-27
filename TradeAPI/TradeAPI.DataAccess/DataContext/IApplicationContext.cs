using TradeAPI.DataAccess.Models;

namespace TradeAPI.DataAccess.DataContext
{
    public interface IApplicationContext
    {
        List<User> Users { get; }
        List<Security> Securities { get; }
        List<Trade> Trades { get; set; }
    }
}
