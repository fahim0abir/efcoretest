using Microsoft.EntityFrameworkCore;

namespace efcorepractice
{
    public class efcoreDBContext : DbContext
    {
        public efcoreDBContext(DbContextOptions<efcoreDBContext> options) : base(options) { }

        public virtual DbSet<Company> Company { get; set; }

        
    }
}
