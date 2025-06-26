using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebDataAnalysis.Domain.Entity;

namespace WebDataAnalysis.Infrastructure.Data.Configuration;

public class FindDeviceConfiguration : IEntityTypeConfiguration<FindDevice>
{
    public void Configure(EntityTypeBuilder<FindDevice> builder)
    {
        builder.HasMany(x => x.DeviceMapping)
            .WithOne(x => x.FindDevice)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.User)
            .WithMany(x => x.FindDevices)
            .OnDelete(DeleteBehavior.NoAction);
    }
}