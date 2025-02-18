using System;
using System.ComponentModel.DataAnnotations;

namespace StockTradingApi.Models{
    public class Portfolio
    {
        [Key]
        public Guid PortfolioId { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public ICollection<PortfolioStock> PortfolioStocks { get; set; } = new List<PortfolioStock>();
    }
}

