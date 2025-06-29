using Microsoft.EntityFrameworkCore;
using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Infrastructure.Data.Configuration;

namespace WebDataAnalysis.Infrastructure.Data;

public class WebDataAnalysisDbContext : DbContext
{

    public WebDataAnalysisDbContext(DbContextOptions options) : base(options)
    {
        
    }
    
    
    public DbSet<Device> Devices { get; set; }
    public DbSet<DeviceMapping> DeviceMappings { get; set; }
    public DbSet<DeviceParameters> DeviceParameters { get; set; }
    public DbSet<FindDevice> FindDevices { get; set; }
    public DbSet<Parameteres> Parameteres { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<StatusDevice> StatusDevices { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new DeviceConfiguration());
        modelBuilder.ApplyConfiguration(new DeviceMappingConfiguration());
        modelBuilder.ApplyConfiguration(new DeviceParametersConfiguration());
        modelBuilder.ApplyConfiguration(new FindDeviceConfiguration());
        modelBuilder.ApplyConfiguration(new ParameteresConfiguration());
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new StatusDeviceConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());

        base.OnModelCreating(modelBuilder);

    }
    
}