using Microsoft.EntityFrameworkCore;

namespace RestEmployCrud.Models
{
    public class EmployDbContext : DbContext
    {
        //Constructor calling the Base DbContext Class Constructor
        public EmployDbContext(DbContextOptions<EmployDbContext> options) : base(options)
        {
        }
        //OnConfiguring() method is used to select and configure the data source
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employ>().ToTable("Employ");
        }

        public DbSet<Employ> Employees { get; set; }
    }
}
