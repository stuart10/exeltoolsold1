using Microsoft.EntityFrameworkCore;

namespace ExelTools.Models
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
{
        }
        public DbSet<WebProduct> WebProducts { get; set; }

    }
}
