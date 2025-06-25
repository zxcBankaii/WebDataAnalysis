namespace WebDataAnalysis.Domain.Entity;

public class Parameteres : BaseEntity
{
    public string Title { get; set; }
    public string Value { get; set; }
    public List<DeviceParameters> DeviceParameters { get; set; }
}