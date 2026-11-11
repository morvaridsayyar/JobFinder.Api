namespace JobFinder.Api.Entity;

public class Company : BaseEntity
{
    public string CompanyName { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Website { get; set; } = null!;
    public string Logo { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public int UserId { get; set; }
    public User User { get; set; } = null!;
}
