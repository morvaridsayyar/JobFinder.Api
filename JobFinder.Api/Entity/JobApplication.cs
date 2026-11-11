namespace JobFinder.Api.Entity;

public class JobApplication : BaseEntity
{
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public int JobId { get; set; }
    public Job Job { get; set; } = null!;
    public string? CoverLetter { get; set; }
    public ApplicationStatus Status { get; set; } = ApplicationStatus.Pending;
}
public enum ApplicationStatus 
{
    Pending,
    Reviewed,
    Accepted,
    Rejected
}

