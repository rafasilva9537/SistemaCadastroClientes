using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcApp.Models;

namespace MvcApp.Data;

public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
{
    public void Configure(EntityTypeBuilder<Fornecedor> builder)
    {
        builder.ToTable("Fornecedores");
        builder.HasKey(f => f.Id);

        builder.Property(f => f.IdPublico)
            .HasDefaultValueSql("NEWID()");
        builder.HasIndex(f => f.IdPublico)
            .IsUnique();

        builder.Property(f => f.Nome).HasMaxLength(100);

        builder.Property(f => f.Cnpj).HasMaxLength(14);

        builder.Property(f => f.Cep).HasMaxLength(8);

        builder.Property(f => f.Endereco).HasMaxLength(255);

        builder.Property(f => f.FotoPerfilPath).HasMaxLength(1000);

        builder.HasOne(f => f.Segmento)
            .WithMany()
            .HasForeignKey(f => f.SegmentoId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
