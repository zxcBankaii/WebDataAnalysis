using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebDataAnalysis.Domain.Entity;

namespace WebDataAnalysis.Infrastructure.Data.Configuration;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasMany(x => x.User)
            .WithOne(x => x.Role)
            .OnDelete(DeleteBehavior.SetNull);
    }
}