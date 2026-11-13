using JobFinder.Api.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinder.Api.Data.EfConfiguration;

public class UserSkillEntityConfiguration : IEntityTypeConfiguration<UserSkill>
{
    public void Configure(EntityTypeBuilder<UserSkill> builder) 
    {
        builder.ToTable("UserSkills");

        builder.HasOne(x => x.User)
            .WithMany(x => x.UserSkills)
            .HasForeignKey(x => x.UserId);

        builder.HasOne(x => x.Skill)
            .WithMany(x => x.UserSkills)
            .HasForeignKey(x => x.SkillId);
    }
}
