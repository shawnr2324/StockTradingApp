using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockTradingApi.Models{
    public class Industry
    {
        [Key]
        public Guid IndustryId { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<StockIndustry> StockIndustries { get; set; } = new List<StockIndustry>();
    }
}

