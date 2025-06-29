namespace WebDataAnalysis.Domain.Entity;

public class Category : BaseEntity
{
    public string Title { get; set; }
    public List<Device> Devices { get; set; }
}