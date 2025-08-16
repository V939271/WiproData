using Microsoft.EntityFrameworkCore;

namespace BankProjectCore.Models
{
    public class BankDbContext : DbContext
    {
        public BankDbContext() { }

        public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
        {
        }

        //OnConfiguring() method is used to select and configure the data source
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Trans>().ToTable("Trans");
            modelBuilder.Entity<Login>().ToTable("Login");
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Trans> Trans { get; set; }

        public DbSet<Login> Logins { get; set; }

    }
}