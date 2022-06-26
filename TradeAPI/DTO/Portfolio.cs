namespace DTO
{
    public class Portfolio
    {
        public User User { get; set; }
        public double PurchasePrice { get; set; }
        public double MarketPrice { get; set; }
        public double Profit => MarketPrice - PurchasePrice;

        public Portfolio(User user, double purchaseValue, double marketValue)
        {
            User = user;
            PurchasePrice = purchaseValue;
            MarketPrice = marketValue;
        }
    }
}
