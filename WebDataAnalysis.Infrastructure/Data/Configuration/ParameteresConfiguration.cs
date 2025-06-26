using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebDataAnalysis.Domain.Entity;

namespace WebDataAnalysis.Infrastructure.Data.Configuration;

public class ParameteresConfiguration : IEntityTypeConfiguration<Parameteres>
{
    public void Configure(EntityTypeBuilder<Parameteres> builder)
    {
        builder.HasMany(x => x.DeviceParameters)
            .WithOne(x => x.Parameteres)
            .OnDelete(DeleteBehavior.Cascade);
    }
}