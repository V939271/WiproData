using Microsoft.EntityFrameworkCore;

namespace EmployCrud.Models
{
    public class HospitalCoreDbContext : DbContext
    {
        public HospitalCoreDbContext(DbContextOptions<HospitalCoreDbContext> options)
            : base(options)
        {
        }

        // Add your DbSets here
        public DbSet<Employ> Employs { get; set; } // Example table
    }
}
