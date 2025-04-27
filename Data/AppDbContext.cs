using IPolicyAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace IPolicyAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Policy> Policies { get; set; }
    }
}
