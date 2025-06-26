using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebDataAnalysis.Domain.Entity;

namespace WebDataAnalysis.Infrastructure.Data.Configuration;

public class DeviceParametersConfiguration : IEntityTypeConfiguration<DeviceParameters>
{
    public void Configure(EntityTypeBuilder<DeviceParameters> builder)
    {
        builder.HasOne(x => x.Device)
            .WithMany(x => x.DeviceParameteres)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.Parameteres)
            .WithMany(x => x.DeviceParameters)
            .OnDelete(DeleteBehavior.NoAction);


    }
}