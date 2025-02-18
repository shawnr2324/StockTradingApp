﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StockTradingApi.Data;

#nullable disable

namespace StockTradingApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250216001450_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("StockTradingApi.Models.Dividend", b =>
                {
                    b.Property<Guid>("DividendsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("DividendAmount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("ExDividendDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("StockId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserID")
                        .HasColumnType("uuid");

                    b.HasKey("DividendsId");

                    b.HasIndex("StockId");

                    b.HasIndex("UserID");

                    b.ToTable("Dividends");
                });

            modelBuilder.Entity("StockTradingApi.Models.Industry", b =>
                {
                    b.Property<Guid>("IndustryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IndustryId");

                    b.ToTable("Industries");
                });

            modelBuilder.Entity("StockTradingApi.Models.Notification", b =>
                {
                    b.Property<Guid>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsRead")
                        .HasColumnType("boolean");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("NotificationId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("StockTradingApi.Models.OptionsContract", b =>
                {
                    b.Property<Guid>("OptionContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Ask")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Bid")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Change")
                        .HasColumnType("numeric");

                    b.Property<string>("ContractName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ContractSymbol")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal?>("Delta")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal?>("Gamma")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("ImpliedVolatility")
                        .HasColumnType("numeric");

                    b.Property<decimal>("LastPrice")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("OpenInterest")
                        .HasColumnType("numeric");

                    b.Property<string>("OptionsContractType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal?>("Rho")
                        .HasColumnType("numeric");

                    b.Property<Guid>("StockID")
                        .HasColumnType("uuid");

                    b.Property<decimal>("StrikePrice")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("Theta")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("Vega")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Volume")
                        .HasColumnType("numeric");

                    b.HasKey("OptionContractId");

                    b.HasIndex("StockID");

                    b.ToTable("OptionsContracts");
                });

            modelBuilder.Entity("StockTradingApi.Models.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal?>("LimitPrice")
                        .HasColumnType("numeric");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("integer");

                    b.Property<string>("OrderType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrderTypeId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric");

                    b.Property<Guid>("StockId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("OrderId");

                    b.HasIndex("StockId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("StockTradingApi.Models.Portfolio", b =>
                {
                    b.Property<Guid>("PortfolioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("StockID")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("PortfolioId");

                    b.HasIndex("StockID");

                    b.HasIndex("UserId");

                    b.ToTable("Portfolios");
                });

            modelBuilder.Entity("StockTradingApi.Models.PortfolioStock", b =>
                {
                    b.Property<Guid>("PortfolioId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("StockId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("AverageBuyPrice")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SharesOwned")
                        .HasColumnType("numeric");

                    b.HasKey("PortfolioId", "StockId");

                    b.HasIndex("StockId");

                    b.ToTable("PortfolioStocks");
                });

            modelBuilder.Entity("StockTradingApi.Models.Stock", b =>
                {
                    b.Property<Guid>("StockID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal?>("CurrentPrice")
                        .HasColumnType("numeric");

                    b.Property<string>("Exchange")
                        .HasColumnType("text");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("StockID");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("StockTradingApi.Models.StockIndustry", b =>
                {
                    b.Property<Guid>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("IndustryId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("StockID")
                        .HasColumnType("uuid");

                    b.HasKey("StockId");

                    b.HasIndex("IndustryId");

                    b.HasIndex("StockID");

                    b.ToTable("StockIndustry");
                });

            modelBuilder.Entity("StockTradingApi.Models.Trade", b =>
                {
                    b.Property<Guid>("TradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("DollarAmount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("ExecutedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric");

                    b.Property<Guid>("StockId")
                        .HasColumnType("uuid");

                    b.Property<int>("TradeStatus")
                        .HasColumnType("integer");

                    b.Property<int>("TradeType")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("TradeId");

                    b.HasIndex("StockId");

                    b.HasIndex("UserId");

                    b.ToTable("Trades");
                });

            modelBuilder.Entity("StockTradingApi.Models.TransactionHistory", b =>
                {
                    b.Property<Guid>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("StockId")
                        .HasColumnType("uuid");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TransactionTypeId")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("TransactionId");

                    b.HasIndex("StockId");

                    b.HasIndex("UserId");

                    b.ToTable("TransactionHistories");
                });

            modelBuilder.Entity("StockTradingApi.Models.User", b =>
                {
                    b.Property<Guid>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StockTradingApi.Models.Watchlist", b =>
                {
                    b.Property<Guid>("WatchlistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("StockId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("WatchlistId");

                    b.HasIndex("StockId");

                    b.HasIndex("UserId");

                    b.ToTable("Watchlists");
                });

            modelBuilder.Entity("StockTradingApi.Models.Dividend", b =>
                {
                    b.HasOne("StockTradingApi.Models.Stock", "Stock")
                        .WithMany("Dividends")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockTradingApi.Models.User", null)
                        .WithMany("Dividends")
                        .HasForeignKey("UserID");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("StockTradingApi.Models.Notification", b =>
                {
                    b.HasOne("StockTradingApi.Models.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("StockTradingApi.Models.OptionsContract", b =>
                {
                    b.HasOne("StockTradingApi.Models.Stock", "Stock")
                        .WithMany("OptionsContracts")
                        .HasForeignKey("StockID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("StockTradingApi.Models.Order", b =>
                {
                    b.HasOne("StockTradingApi.Models.Stock", "Stock")
                        .WithMany("Orders")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockTradingApi.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stock");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StockTradingApi.Models.Portfolio", b =>
                {
                    b.HasOne("StockTradingApi.Models.Stock", null)
                        .WithMany("Portfolios")
                        .HasForeignKey("StockID");

                    b.HasOne("StockTradingApi.Models.User", "User")
                        .WithMany("Portfolios")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("StockTradingApi.Models.PortfolioStock", b =>
                {
                    b.HasOne("StockTradingApi.Models.Portfolio", "Portfolio")
                        .WithMany("PortfolioStocks")
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockTradingApi.Models.Stock", "Stock")
                        .WithMany("PortfolioStocks")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Portfolio");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("StockTradingApi.Models.StockIndustry", b =>
                {
                    b.HasOne("StockTradingApi.Models.Industry", "Industry")
                        .WithMany("StockIndustries")
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockTradingApi.Models.Stock", "Stock")
                        .WithMany("StockIndustries")
                        .HasForeignKey("StockID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Industry");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("StockTradingApi.Models.Trade", b =>
                {
                    b.HasOne("StockTradingApi.Models.Stock", "Stock")
                        .WithMany("Trades")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockTradingApi.Models.User", "User")
                        .WithMany("Trades")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stock");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StockTradingApi.Models.TransactionHistory", b =>
                {
                    b.HasOne("StockTradingApi.Models.Stock", "Stock")
                        .WithMany("TransactionHistories")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockTradingApi.Models.User", "User")
                        .WithMany("TransactionHistories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stock");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StockTradingApi.Models.Watchlist", b =>
                {
                    b.HasOne("StockTradingApi.Models.Stock", "Stock")
                        .WithMany("Watchlists")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockTradingApi.Models.User", "User")
                        .WithMany("Watchlists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stock");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StockTradingApi.Models.Industry", b =>
                {
                    b.Navigation("StockIndustries");
                });

            modelBuilder.Entity("StockTradingApi.Models.Portfolio", b =>
                {
                    b.Navigation("PortfolioStocks");
                });

            modelBuilder.Entity("StockTradingApi.Models.Stock", b =>
                {
                    b.Navigation("Dividends");

                    b.Navigation("OptionsContracts");

                    b.Navigation("Orders");

                    b.Navigation("PortfolioStocks");

                    b.Navigation("Portfolios");

                    b.Navigation("StockIndustries");

                    b.Navigation("Trades");

                    b.Navigation("TransactionHistories");

                    b.Navigation("Watchlists");
                });

            modelBuilder.Entity("StockTradingApi.Models.User", b =>
                {
                    b.Navigation("Dividends");

                    b.Navigation("Notifications");

                    b.Navigation("Orders");

                    b.Navigation("Portfolios");

                    b.Navigation("Trades");

                    b.Navigation("TransactionHistories");

                    b.Navigation("Watchlists");
                });
#pragma warning restore 612, 618
        }
    }
}
