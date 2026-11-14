namespace JobFinder.Api.Entity;

public class User : BaseEntity
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string NationalCode { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public bool IsActive { get; set; } = true;
    public int RoleId { get; set; }
    public Role Role { get; set; } = null!;
    public Company Company { get; set; } = null!;
    public Resume? Resume { get; set; }
    public List<UserSkill> UserSkills { get; set; } = null!;
    public List<JobApplication> JobApplications { get; set; } = null!;
}

