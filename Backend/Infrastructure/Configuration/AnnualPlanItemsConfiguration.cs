using Domain.Constants;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class AnnualPlanItemsConfiguration
        : IEntityTypeConfiguration<AnnualPlanItems>
    {
        public void Configure(EntityTypeBuilder<AnnualPlanItems> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.TariffNumber)
                .IsRequired()
                .HasMaxLength(MaxLength.Short);

            builder.Property(x => x.UnitOfMeasurement)
                .IsRequired()
                .HasMaxLength(MaxLength.Short);

            builder.Property(x => x.FinalProduct)
                .IsRequired()
                .HasMaxLength(MaxLength.Medium);

            builder.Property(x => x.Quantity)
                .IsRequired();

            builder.Property(x => x.Remarks)
                .HasMaxLength(MaxLength.Large);

            builder.HasOne(x => x.AnnualPlan)
                .WithMany(x => x.AnnualPlanItems)
                .HasForeignKey(x => x.AnnualPlanId);
        }
    }
}