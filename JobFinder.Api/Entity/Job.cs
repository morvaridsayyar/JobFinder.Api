namespace JobFinder.Api.Entity;

public class Job : BaseEntity
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Salary { get; set; }
    public string Location { get; set; } = null!;
    public string JobType { get; set; } = null!;
    public int CompanyId { get; set;  }
    public Company Company { get; set; } = null!;
    public int JobCategoryId { get; set; }
    public JobCategory JobCategory { get; set;} = null!;
    public List<JobSkill> JobSkills { get; set; } = null!;
    public List<JobApplication> JobApplications { get; set; } = null!;
}
