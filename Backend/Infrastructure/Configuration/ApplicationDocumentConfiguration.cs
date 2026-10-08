using Domain.Constants;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class ApplicationDocumentConfiguration
        : IEntityTypeConfiguration<ApplicationDocument>
    {
        public void Configure(EntityTypeBuilder<ApplicationDocument> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FileName)
                .IsRequired()
                .HasMaxLength(MaxLength.Medium);

            builder.Property(x => x.FilePath)
                .IsRequired()
                .HasMaxLength(MaxLength.Large);

            builder.Property(x => x.ContentType)
                .IsRequired()
                .HasMaxLength(MaxLength.Medium);

            builder.Property(x => x.DocumentType)
                .IsRequired()
                .HasMaxLength(MaxLength.Short);

            builder.HasOne(x => x.ApplicationRequest)
                .WithMany(x => x.ApplicationDocuments)
                .HasForeignKey(x => x.ApplicationRequestId);
        }
    }
}