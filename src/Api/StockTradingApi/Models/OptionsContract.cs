using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockTradingApi.Models
{
    public class OptionsContract
    {
        [Key]
        public Guid OptionContractId { get; set; } = Guid.NewGuid();
        public Stock Stock { get; set; } = null!;
        public string ContractName { get; set; } = string.Empty;
        public string ContractSymbol { get; set; }  = string.Empty;
        public OptionsContractType OptionsContractType { get; set; }
        public decimal StrikePrice { get; set; }
        public DateTime ExpirationDate { get; set; } = DateTime.UtcNow;
        public decimal LastPrice { get; set; }
        public decimal Change { get; set; }
        public decimal Bid { get; set; }
        public decimal Ask { get; set; }
        public decimal Volume { get; set; }
        public decimal? OpenInterest { get; set; }
        public decimal? ImpliedVolatility { get; set; }
        public decimal? Delta { get; set; }
        public decimal? Gamma { get; set; }
        public decimal? Theta { get; set; }
        public decimal? Vega { get; set; }
        public decimal? Rho { get; set; }
    }

    public enum OptionsContractType
    {
        Call,
        Put
    }
}

