using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebDataAnalysis.Domain.Entity;

namespace WebDataAnalysis.Infrastructure.Data.Configuration;

public class DeviceMappingConfiguration : IEntityTypeConfiguration<DeviceMapping>
{
    public void Configure(EntityTypeBuilder<DeviceMapping> builder)
    {
        builder.HasOne(x => x.FindDevice)
            .WithMany(x => x.DeviceMapping)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x => x.Device)
            .WithMany(x => x.DeviceMapping)
            .OnDelete(DeleteBehavior.Cascade);
    }
}