namespace JobFinder.Api.Entity;

public class JobCategory : BaseEntity
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public List<Job> Jobs { get; set; } = null!;
}
