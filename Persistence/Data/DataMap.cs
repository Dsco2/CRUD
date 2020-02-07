using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data
{
    public class DataMap : IEntityTypeConfiguration<Business.Data.Data>
    {
        public void Configure(EntityTypeBuilder<Business.Data.Data> builder)
        {
            builder.ToTable("data", null);
            builder.HasKey(x => x.IdData);
        }
    }
}
