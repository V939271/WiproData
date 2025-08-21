using Microsoft.EntityFrameworkCore;

namespace JwtExampleDotnet.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}