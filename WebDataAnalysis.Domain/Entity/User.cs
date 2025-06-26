namespace WebDataAnalysis.Domain.Entity;

public class User : BaseEntity
{
    public string FIO { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public Role? Role { get; set; }
    public List<FindDevice> FindDevices { get; set; }
}