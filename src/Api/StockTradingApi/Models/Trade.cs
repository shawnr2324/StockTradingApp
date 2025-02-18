using System;
using System.ComponentModel.DataAnnotations;

namespace StockTradingApi.Models{
    public class Trade
    {
        [Key]
        public Guid TradeId { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public Guid StockId { get; set; }
        public Stock Stock { get; set; } = null!;
        public TradeType TradeType { get; set; }
        public decimal Quantity { get; set; }
        public decimal DollarAmount { get; set; }
        public TradeStatus TradeStatus { get; set; } = TradeStatus.Pending;
        public DateTime ExecutedAt { get; set; } = DateTime.UtcNow;
    }

    public enum TradeType
    {
        Buy,
        Sell
    }

    public enum TradeStatus
    {
        Pending,
        Executed,
        Canceled
    }
}

