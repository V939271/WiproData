using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class CmsDbContext : DbContext
    {
        public CmsDbContext(DbContextOptions<CmsDbContext> opts) : base(opts) { }
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Wallet> Wallets => Set<Wallet>();

    }
}
