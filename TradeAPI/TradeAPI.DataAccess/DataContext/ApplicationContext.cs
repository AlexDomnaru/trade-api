using TradeAPI.DataAccess.Models;

namespace TradeAPI.DataAccess.DataContext
{
    public class ApplicationContext : IApplicationContext
    {
        public List<User> Users { get; set; }

        public List<Security> Securities { get; set; }

        public List<Trade> Trades { get; set; }

        public ApplicationContext()
        {
            Users = new()
            {
                new User(1, "Alex"),
                new User(2, "George")
            };
            Securities = new()
            {
                new Security(1, "MSFT", 10.0),
                new Security(2, "AAPL", 12.0),
                new Security(3, "GOOG", 15.0)
            }; 
            Trades = new()
            {
                new Trade(1, 10.0, 3, new DateTime(2022, 03, 01), 1, 1),
                new Trade(2, 11.0, 1, new DateTime(2022, 03, 01), 2, 1),
                new Trade(3, 16.0, 2, new DateTime(2022, 03, 01), 2, 1),
                new Trade(4, 9.5, 2, new DateTime(2022, 02, 01), 1, 2),
                new Trade(5, 12.0, 2, new DateTime(2022, 02, 01), 2, 2),
                new Trade(6, 15.0, 3, new DateTime(2022, 02, 01), 3, 2)
            };
        }
    }
}
