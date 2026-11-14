using JobFinder.Api.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinder.Api.Data.EfConfiguration;

public class JobApplicationEntityConfiguration : IEntityTypeConfiguration<JobApplication>
{
    public void Configure(EntityTypeBuilder<JobApplication> builder) 
    {
        builder.ToTable("JobApplications");

        builder.Property(x => x.CoverLetter)
            .HasMaxLength(1000);

        builder.Property(x => x.Status)
            .IsRequired();

        builder.HasOne(x => x.User)
            .WithMany(x => x.JobApplications)
            .HasForeignKey(x => x.UserId);

        builder.HasOne(x => x.Job)
            .WithMany(x => x.JobApplications)
            .HasForeignKey(x => x.JobId);
    }
}
