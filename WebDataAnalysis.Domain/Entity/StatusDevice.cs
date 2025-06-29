namespace WebDataAnalysis.Domain.Entity;

public class StatusDevice : BaseEntity
{
    public string Status { get; set; }
    public List<Device> Devices { get; set; }
}