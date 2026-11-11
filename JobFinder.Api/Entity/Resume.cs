namespace JobFinder.Api.Entity;

public class Resume : BaseEntity
{
    public int UserId { get; set; }
    public string Url { get; set; } = null!;
    public User User { get; set; } = null!;
}
