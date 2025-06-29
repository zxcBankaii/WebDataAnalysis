namespace WebDataAnalysis.Domain.Entity;

public class Device : BaseEntity
{
    public string Title { get; set; }
    public List<DeviceParameters> DeviceParameteres { get; set; }
    public List<DeviceMapping> DeviceMapping { get; set; }
    public StatusDevice StatusDevice { get; set; }
    public Category Category { get; set; }
}