using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockTradingApi.Models{
    public class User{
        [Key]
        public Guid UserID { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Navigation Properties
        public ICollection<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
        public ICollection<Trade> Trades { get; set; } = new List<Trade>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<TransactionHistory> TransactionHistories { get; set; } = new List<TransactionHistory>();
        public ICollection<Watchlist> Watchlists { get; set; } = new List<Watchlist>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public ICollection<Dividend> Dividends { get; set; } = new List<Dividend>();
    }
}