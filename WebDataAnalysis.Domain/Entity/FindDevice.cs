namespace WebDataAnalysis.Domain.Entity;

public class FindDevice : BaseEntity
{
    public string MAC { get; set; }
    public string SpectrumOfWave { get; set; }
    public string LenghtOfWave { get; set; }
    public User? User { get; set; }
    public List<DeviceMapping> DeviceMapping { get; set; }
    public StatusDevice? StatusDevice { get; set; }

}