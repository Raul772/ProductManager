using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RL.Business.Models;

namespace RL.Data.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {

        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(x => x.Documento)
                .HasColumnType("varchar(14)")
                .IsRequired();


        // Relacionamentos do EntityFramework
        // Relacionamento 1 : 1
            builder.HasOne(x => x.Endereco)
                .WithOne(x => x.Fornecedor);

        // Relacionamento 1 : N
            builder.HasMany(x => x.Produtos)
                .WithOne(x => x.Fornecedor)
                .HasForeignKey(x => x.FornecedorId);

            builder.ToTable("fornecedores");
        }
    }
}
