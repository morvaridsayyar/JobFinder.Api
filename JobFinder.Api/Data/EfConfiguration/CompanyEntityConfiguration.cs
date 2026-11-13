using JobFinder.Api.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinder.Api.Data.EfConfiguration;

public class CompanyEntityConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.ToTable("Companies");

        builder.Property(x => x.CompanyName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Description)
            .IsRequired();

        builder.Property(x => x.Website)
            .HasMaxLength(200);

        builder.Property(x => x.Logo)
            .HasMaxLength(500);

        builder.Property(x => x.Address)
            .IsRequired();

        builder.Property(x => x.PhoneNumber)
            .IsRequired()
            .HasMaxLength(16);

        builder.HasOne(x => x.User)
            .WithOne(x => x.Company)
            .HasForeignKey(x => x.UserId);
    }
}

