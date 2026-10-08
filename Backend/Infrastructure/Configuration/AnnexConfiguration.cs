using Domain.Constants;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class AnnexConfiguration : IEntityTypeConfiguration<Annex>
    {
        public void Configure(EntityTypeBuilder<Annex> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(MaxLength.Short);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(MaxLength.Large);

            builder.HasOne(x => x.ApplicationRequest)
                .WithMany(x => x.Annexes)
                .HasForeignKey(x => x.ApplicationRequestId);
        }
    }
}