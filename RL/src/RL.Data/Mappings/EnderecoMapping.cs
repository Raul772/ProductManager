using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RL.Business.Models;

namespace RL.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {

        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Logradouro)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(x => x.Numero)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Cep)
                .HasColumnType("varchar(8)")
                .IsRequired();

            builder.Property(x => x.Complemento)
                .HasColumnType("varchar(250)")
                .IsRequired();

            builder.Property(x => x.Bairro)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Cidade)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Estado)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.ToTable("enderecos");
        }
    }


}
