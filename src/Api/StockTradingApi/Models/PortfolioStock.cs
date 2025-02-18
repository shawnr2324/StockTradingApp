using System;
using System.Collections.Generic;

namespace StockTradingApi.Models{
    public class PortfolioStock
    {
        public Guid PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; } = null!;
        public Guid StockId { get; set; }
        public Stock Stock { get; set; } = null!;
        public decimal SharesOwned { get; set; } = 0;
        public decimal AverageBuyPrice { get; set; } = 0;
    }
}