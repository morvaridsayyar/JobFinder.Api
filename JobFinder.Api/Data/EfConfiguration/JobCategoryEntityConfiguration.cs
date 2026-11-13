using JobFinder.Api.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinder.Api.Data.EfConfiguration;

public class JobCategoryEntityConfiguration : IEntityTypeConfiguration<JobCategory>
{
    public void Configure(EntityTypeBuilder<JobCategory> builder) 
    {
        builder.ToTable("JobCategories");

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Description)
            .IsRequired();

        builder.HasMany(x => x.Jobs)
            .WithOne(x => x.JobCategory)
            .HasForeignKey(x => x.JobCategoryId);
    }
}

