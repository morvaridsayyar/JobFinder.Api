namespace JobFinder.Api.Entity;

public class Skill : BaseEntity
{
    public string Name { get; set; } = null!;
    public List<JobSkill> JobSkills { get; set; } = null!;
    public List<UserSkill> UserSkills { get; set; } = null!;
}
