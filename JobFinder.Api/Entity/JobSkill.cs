namespace JobFinder.Api.Entity;

public class JobSkill : BaseEntity
{
    public int JobId { get; set; }
    public Job Job { get; set; } = null!;
    public int SkillId { get; set; }
    public Skill Skill { get; set; } = null!;
}
