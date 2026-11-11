
using JobFinder.Api.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace JobFinder.Api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<JobCategory> JobCategories { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<JobSkill> JobSkills { get; set; }
    public DbSet<UserSkill> UserSkills { get; set; }
    public DbSet<Resume> Resumes { get; set; }
    public DbSet<JobApplication> JobApplications { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(ApplicationDbContext).Assembly);
    }
}
