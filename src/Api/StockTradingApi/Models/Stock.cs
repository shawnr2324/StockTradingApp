using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockTradingApi.Models{
    public class Stock{
        [Key]
        public Guid StockID { get; set; } = Guid.NewGuid();
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string? Exchange { get; set; }
        public decimal? CurrentPrice { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties
        public ICollection<StockIndustry> StockIndustries { get; set; } = new List<StockIndustry>();
        public ICollection<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
        public ICollection<Trade> Trades { get; set; } = new List<Trade>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<TransactionHistory> TransactionHistories { get; set; } = new List<TransactionHistory>();
        public ICollection<Watchlist> Watchlists { get; set; } = new List<Watchlist>();
        public ICollection<Dividend> Dividends { get; set; } = new List<Dividend>();
        public ICollection<OptionsContract> OptionsContracts { get; set; } = new List<OptionsContract>();
        public ICollection<PortfolioStock> PortfolioStocks { get; set; } = new List<PortfolioStock>();
    }
}