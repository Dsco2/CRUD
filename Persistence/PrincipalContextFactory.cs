using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Persistence
{
    public class PrincipalContextFactory : IDesignTimeDbContextFactory<PrincipalContext>
    {
        public PrincipalContext CreateDbContext(string[] args)
        {
            var builder= new DbContextOptionsBuilder<PrincipalContext>();
            builder.UseSqlServer("Server=DESKTOP-BDPS627;Database=TestDB",
                optionsBuilder => optionsBuilder
                    .MigrationsAssembly(typeof(PrincipalContext)
                    .GetTypeInfo()
                    .Assembly
                    .GetName().Name)
                );
            return new PrincipalContext(builder.Options);
        }
    }
}
