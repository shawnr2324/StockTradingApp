using System;
using System.ComponentModel.DataAnnotations;

namespace StockTradingApi.Models{
    public class StockIndustry
    {
        [Key]
        public Guid StockId { get; set; }
        public Stock Stock { get; set; } = null!;
        public Guid IndustryId { get; set; }
        public Industry Industry { get; set; } = null!;
    }
}

