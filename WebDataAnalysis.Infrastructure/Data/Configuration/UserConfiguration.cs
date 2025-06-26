using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebDataAnalysis.Domain.Entity;

namespace WebDataAnalysis.Infrastructure.Data.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasOne(x => x.Role)
            .WithMany(x => x.User)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(x => x.FindDevices)
            .WithOne(x => x.User)
            .OnDelete(DeleteBehavior.SetNull);
    }
}