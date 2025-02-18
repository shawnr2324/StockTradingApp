using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockTradingApi.Models
{
    public class Watchlist
    {
        [Key]
        public Guid WatchlistId { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public Guid StockId { get; set; }
        public Stock Stock { get; set; } = null!;
    }
}