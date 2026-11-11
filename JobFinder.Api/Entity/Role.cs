namespace JobFinder.Api.Entity;

public class Role :BaseEntity
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public List<User> Users { get; set; } = null!;
}
