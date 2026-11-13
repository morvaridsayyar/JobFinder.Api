using JobFinder.Api.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinder.Api.Data.EfConfiguration;

public class JobSkillEntityConfiguration : IEntityTypeConfiguration<JobSkill>
{
    public void Configure(EntityTypeBuilder<JobSkill> builder) 
    {
        builder.ToTable("JobSkills");

        builder.HasOne(x => x.Job)
            .WithMany(x => x.JobSkill)
            .HasForeignKey(x => x.JobId);

        builder.HasOne(x => x.Skill)
            .WithMany(x => x.JobSkill)
            .HasForeignKey(x => x.SkillId);
    }
}
