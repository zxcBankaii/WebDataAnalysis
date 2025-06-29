using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebDataAnalysis.Domain.Entity;

namespace WebDataAnalysis.Infrastructure.Data.Configuration;

public class StatusDeviceConfiguration : IEntityTypeConfiguration<StatusDevice>
{
    public void Configure(EntityTypeBuilder<StatusDevice> builder)
    {
        builder.HasMany(x => x.FindDevices)
            .WithOne(x => x.StatusDevice)
            .OnDelete(DeleteBehavior.SetNull);
    }
}