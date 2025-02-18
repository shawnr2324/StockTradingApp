using System;
using System.ComponentModel.DataAnnotations;

namespace StockTradingApi.Models{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public Guid StockId { get; set; }
        public Stock Stock { get; set; } = null!;
        public int OrderTypeId { get; set; }
        public OrderType OrderType { get; set; }
        public decimal? LimitPrice { get; set; }
        public decimal Quantity { get; set; }
        public int OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

    public enum OrderType
    {
        Market,
        Limit,
        Stop,
        StopLimit
    }

    public enum OrderStatus
    {
        Pending,
        Executed,
        Canceled
    }

}
