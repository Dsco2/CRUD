using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Persistence
{
    public class PrincipalContext : DbContext
    {
        public DbSet<Business.Data.Data> Data { get; set; }

        public PrincipalContext(DbContextOptions<PrincipalContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DataMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
