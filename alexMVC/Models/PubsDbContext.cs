using Microsoft.EntityFrameworkCore;

namespace alexMVC.Models
{
    public class PubsDbContext : DbContext
    {
        public PubsDbContext(DbContextOptions<PubsDbContext> options) : base(options)
        {
        };

        public DbSet<Author> Authors { get; set; }
        
    }
}