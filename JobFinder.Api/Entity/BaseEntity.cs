namespace JobFinder.Api.Entity;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedTime { get; set; } = DateTime.Now;
}

