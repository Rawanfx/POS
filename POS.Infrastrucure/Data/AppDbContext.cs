using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using POS.Domain.Entities;

namespace POS.Infrastrucure.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {  }
        public DbSet<Branch> Branches => Set<Branch>();
        public DbSet<Category>Categories=> Set<Category>();
        public DbSet<ExpenseType> ExpenseTypes => Set<ExpenseType>();
        public DbSet<Inventory> Inventories => Set<Inventory>();
        public DbSet<LedgerEntry> LedgerEntries => Set<LedgerEntry>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Purchase> Purchases => Set<Purchase>();
        public DbSet<PurchaseItems> PurchaseItems => Set<PurchaseItems>();
        public DbSet<Sale> Sales=> Set<Sale>();
        public DbSet<SaleItems> SaleItems=> Set<SaleItems>();
        public DbSet<StockTransferItem> StockTransferItems=> Set<StockTransferItem>();
        public DbSet<StockTransfer> StockTransfers=> Set<StockTransfer>();
        public DbSet<Supplier> Suppliers=> Set<Supplier>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<PurchaseItems>().HasKey(pi => new { pi.PurchaseId, pi.ProductId });
            builder.Entity<SaleItems>().HasKey(si => new { si.SalesId, si.ProductId });
            builder.Entity<StockTransferItem>().HasKey(sti => new { sti.StockTransferId, sti.ProductId });
        }
    }
}
