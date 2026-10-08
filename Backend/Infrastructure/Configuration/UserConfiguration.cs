using Domain.Constants;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(MaxLength.Short);

            builder.Property(x => x.Surname)
                .IsRequired()
                .HasMaxLength(MaxLength.Short);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(MaxLength.Medium);

            builder.Property(x => x.Adress)
                .IsRequired()
                .HasMaxLength(MaxLength.Short);

            builder.Property(x => x.PersonalNumber)
                .IsRequired()
                .HasMaxLength(MaxLength.Short);

            builder.Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(MaxLength.Short);

            builder.HasIndex(x => x.PersonalNumber)
                .IsUnique();
        }
    }
}