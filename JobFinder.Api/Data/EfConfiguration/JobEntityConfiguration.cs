using JobFinder.Api.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinder.Api.Data.EfConfiguration;

public class JobEntityConfiguration : IEntityTypeConfiguration<Job>
{
    public void Configure(EntityTypeBuilder<Job> builder) 
    {
        builder.ToTable("Jobs");

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(x => x.Salary)
            .IsRequired();

        builder.Property(x => x.Location)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.JobType)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasOne(x => x.Company)
            .WithMany(x => x.Jobs)
            .HasForeignKey(x => x.CompanyId);

        builder.HasOne(x => x.JobCategory)
            .WithMany(x => x.Jobs)
            .HasForeignKey(x => x.JobCategoryId);

        builder.HasMany(x => x.JobSkills)
            .WithOne(x => x.Job)
            .HasForeignKey(x => x.JobId);
    }
}
