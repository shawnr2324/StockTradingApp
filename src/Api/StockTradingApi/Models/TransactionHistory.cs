using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockTradingApi.Models
{
    public class TransactionHistory
    {
        [Key]
        public Guid TransactionId { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public Guid StockId { get; set; }
        public Stock Stock { get; set; } = null!;
        public int TransactionTypeId { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

    public enum TransactionType
    {
        Withdrawal,
        Deposit,
        Dividend,
        TradeExecution

    }
}