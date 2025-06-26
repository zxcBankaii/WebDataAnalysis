using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebDataAnalysis.Domain.Entity;

namespace WebDataAnalysis.Infrastructure.Data.Configuration;

public class DeviceConfiguration : IEntityTypeConfiguration<Device>
{
    public void Configure(EntityTypeBuilder<Device> builder)
    {
        builder.HasMany(x => x.DeviceMapping)
            .WithOne(x => x.Device)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(x => x.DeviceParameteres)
            .WithOne(x => x.Device)
            .OnDelete(DeleteBehavior.Cascade);
        
    }
}