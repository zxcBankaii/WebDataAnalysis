namespace WebDataAnalysis.Domain.Entity;

public class Role : BaseEntity
{
    public string Title { get; set; }
    public List<User> User { get; set; }
}