using JobFinder.Api.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinder.Api.Data.EfConfiguration;

public class ResumeEntityConfiguration : IEntityTypeConfiguration<Resume>
{
    public void Configure(EntityTypeBuilder<Resume> builder) 
    {
        builder.ToTable("Resumes");

        builder.Property(x => x.Url)
            .IsRequired()
            .HasMaxLength(1000);

        builder.HasOne(x => x.User)
            .WithOne(x => x.Resume)
            .HasForeignKey(x => x.UserId);
    }
}
