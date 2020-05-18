using System;
using lemosinfotec.acaciovistorias.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lemosinfotec.acaciovistorias.Data.EntityConfig
{
    public class ImobiliariaConfiguration : IEntityTypeConfiguration<Imobiliarias>
    {
        public void Configure(EntityTypeBuilder<Imobiliarias> builder)
        {
            builder.ToTable("Imobiliarias");
            builder.HasKey(x=>x.ImobiliariaId);

            builder.Property(x=>x.ImobiliariaNome)
            .HasColumnType("varchar(50)")
            .IsRequired();

            builder.Property(x=>x.Endereco)
            .HasColumnType("varchar(50)")
            .IsRequired();

            builder.Property(x=>x.Numero)
            .HasColumnType("int")
            .IsRequired();

            builder.Property(X=>X.Bairro)
            .HasColumnType("varchar(50)")
            .IsRequired();

            builder.Property(x=>x.Cidade)
            .HasColumnType("varchar(50)")
            .IsRequired();

            builder.Property(x=>x.uf)
            .HasColumnType("varchar(2)")
            .IsRequired();

            builder.Property(x=>x.Cnpj)
            .HasColumnType("varchar(11)")
            .IsRequired();

            builder.Property(x=>x.Cep)
            .HasColumnType("varchar(11)")
            .IsRequired();
            

        }
    }
}
