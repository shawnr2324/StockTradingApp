using Microsoft.EntityFrameworkCore;
using StockTradingApi.Models; // Make sure this namespace matches where your EF classes are defined

namespace StockTradingApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets for each entity
        public DbSet<User> Users { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioStock> PortfolioStocks { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<TransactionHistory> TransactionHistories { get; set; }
        public DbSet<Watchlist> Watchlists { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Dividend> Dividends { get; set; }
        public DbSet<OptionsContract> OptionsContracts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure composite key for join table (PortfolioStock)
            modelBuilder.Entity<PortfolioStock>()
                .HasKey(ps => new { ps.PortfolioId, ps.StockId });

            modelBuilder.Entity<PortfolioStock>()
                .HasOne(ps => ps.Portfolio)
                .WithMany(p => p.PortfolioStocks)
                .HasForeignKey(ps => ps.PortfolioId);

            modelBuilder.Entity<PortfolioStock>()
                .HasOne(ps => ps.Stock)
                .WithMany(s => s.PortfolioStocks)
                .HasForeignKey(ps => ps.StockId);

            // Further configuration for reference tables: store enums as strings for better readability

            modelBuilder.Entity<Order>()
                .Property(o => o.OrderType)
                .HasConversion<string>();

            modelBuilder.Entity<Order>()
                .Property(o => o.OrderStatus)
                .HasConversion<string>();

            modelBuilder.Entity<TransactionHistory>()
                .Property(t => t.TransactionType)
                .HasConversion<string>();

            modelBuilder.Entity<OptionsContract>()
                .Property(o => o.OptionsContractType)
                .HasConversion<string>();
        }
    }
}
