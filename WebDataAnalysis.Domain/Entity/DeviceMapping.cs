namespace WebDataAnalysis.Domain.Entity;

public class DeviceMapping : BaseEntity
{
    public FindDevice FindDevice { get; set; }
    public Device Device { get; set; }
}