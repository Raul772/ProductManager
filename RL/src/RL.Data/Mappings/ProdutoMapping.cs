using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RL.Business.Models;

namespace RL.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {

        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id); 

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(1000)")
                .IsRequired();

            builder.Property(x => x.imagem)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.ToTable("produtos");
        }
    }
}
