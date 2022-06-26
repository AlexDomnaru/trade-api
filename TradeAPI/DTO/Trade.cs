namespace DTO
{
    public class Trade
    {
        public int Id { get; set; }
        public double TradePrice { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public Security Security { get; set; }
        public User User { get; set; }

        public Trade(int id, double price, int quantity, DateTime date, Security security, User user)
        {
            Id = id;
            TradePrice = price;
            Quantity = quantity;
            Date = date;
            Security = security;
            User = user;
        }
    }
}
