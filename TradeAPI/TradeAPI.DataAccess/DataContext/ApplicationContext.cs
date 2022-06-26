using TradeAPI.DataAccess.Models;

namespace TradeAPI.DataAccess.DataContext
{
    public class ApplicationContext
    {
        public List<User> Users;
        public List<Security> Securities;
        public List<Trade> Trades;

        public ApplicationContext()
        {
            Users = new() { new User(1, "Alex"), new User(2, "George") };
            Securities = new() { new Security(1, "MSFT", 10.0), new Security(1, "AAPL", 12.0), new Security(1, "GOOG", 15.0) };
            Trades = new()
            {
                new Trade(10.0, 3, new DateTime(2022, 03, 01), 1, 1),
                new Trade(11.0, 1, new DateTime(2022, 03, 01), 2, 1),
                new Trade(16.0, 2, new DateTime(2022, 03, 01), 3, 1),
                new Trade(9.5, 2, new DateTime(2022, 02, 01), 1, 2),
                new Trade(12.0, 2, new DateTime(2022, 02, 01), 2, 2),
                new Trade(15.0, 3, new DateTime(2022, 02, 01), 3, 3)
            };
        }

    }
}
