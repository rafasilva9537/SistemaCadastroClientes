using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcApp.Models;

namespace MvcApp.Data;

public class SegmentoConfiguration : IEntityTypeConfiguration<Segmento>
{
    public void Configure(EntityTypeBuilder<Segmento> builder)
    {
        builder.ToTable("Segmentos");
        builder.HasKey(s => s.Id);

        builder.Property(s => s.Name).HasMaxLength(100);
    }
}
