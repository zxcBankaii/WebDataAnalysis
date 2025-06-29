namespace WebDataAnalysis.Domain.Entity;

public class StatusDevice : BaseEntity
{
    public string Status { get; set; }
    public List<FindDevice> FindDevices { get; set; }
}