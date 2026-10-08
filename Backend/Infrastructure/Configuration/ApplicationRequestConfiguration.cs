using Domain.Constants;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class ApplicationRequestConfiguration
        : IEntityTypeConfiguration<ApplicationRequest>
    {
        public void Configure(EntityTypeBuilder<ApplicationRequest> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ApplicationNumber)
                .IsRequired()
                .HasMaxLength(MaxLength.Short);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(MaxLength.Short);

            builder.Property(x => x.NUI)
                .IsRequired()
                .HasMaxLength(9);

            builder.Property(x => x.Address)
                .IsRequired()
                .HasMaxLength(MaxLength.Short);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(MaxLength.Short);

            builder.Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(MaxLength.Short);

            builder.Property(x => x.Manager)
                .IsRequired()
                .HasMaxLength(MaxLength.Short);
        }
    }
}