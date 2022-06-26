﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAPI.DataAccess.Models
{
    public class Security
    {
        public int Id { get; set; }

        public string SecurityCode { get; set; }

        public double MarketPrice { get; set; }


        public Security(int id, string securityCode, double price)
        {
            Id = id;
            SecurityCode = securityCode;
            MarketPrice = price;
        }
    }
}
