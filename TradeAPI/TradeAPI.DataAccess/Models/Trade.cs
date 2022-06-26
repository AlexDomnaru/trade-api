using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAPI.DataAccess.Models
{
    public class Trade
    {
        public int Id { get; set; }

        public double TradePrice { get; set; }

        public int Quantity { get; set; }

        public DateTime Date { get; set; }

        public int SecurityId { get; set; }

        public int BuyerId { get; set; }

        public Trade(double price, int quantity, DateTime date, int securityId, int buyerId)
        {
            TradePrice = price;
            Quantity = quantity;
            Date = date;
            SecurityId = securityId;
            BuyerId = buyerId;
        }
    }
}
