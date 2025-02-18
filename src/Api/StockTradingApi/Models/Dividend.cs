using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockTradingApi.Models{
    public class Dividend
    {
        [Key]
        public Guid DividendsId { get; set; } = Guid.NewGuid();
        public Guid StockId { get; set; }
        public Stock Stock { get; set; } = null!;
        public DateTime ExDividendDate { get; set; } = DateTime.UtcNow;
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
        public decimal DividendAmount { get; set; }
    }
}