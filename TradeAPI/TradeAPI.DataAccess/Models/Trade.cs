namespace TradeAPI.DataAccess.Models
{
    public class Trade
    {
        public int Id { get; set; }
        public double TradePrice { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public int SecurityId { get; set; }
        public int UserId { get; set; }

        public Trade(int id, double price, int quantity, DateTime date, int securityId, int userId)
        {
            Id = id;
            TradePrice = price;
            Quantity = quantity;
            Date = date;
            SecurityId = securityId;
            UserId = userId;
        }

        public Trade(double price, int quantity, DateTime date, int securityId, int userId)
        {
            TradePrice = price;
            Quantity = quantity;
            Date = date;
            SecurityId = securityId;
            UserId = userId;
        }
    }
}
