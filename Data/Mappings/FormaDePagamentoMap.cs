using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vendas.Models;

namespace Vendas.Data.Mappings
{
    public class FormaDePagamentoMap : IEntityTypeConfiguration<FormaDePagamento>
    {
        public void Configure(EntityTypeBuilder<FormaDePagamento> builder)
        {
            // Tabela
            builder.ToTable("FormaDePagamento");

            // Chave Primária
            builder.HasKey(x => x.Id);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            // Propriedades
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);

            // Propriedades
            builder.Property(x => x.Prazo)
                .IsRequired()
                .HasColumnName("Prazo")
                .HasColumnType("INT");

            // Propriedades
            builder.Property(x => x.Taxa)
                .IsRequired()
                .HasColumnName("Taxa")
                .HasColumnType("FLOAT")
                .HasMaxLength(100);


            builder.Property(x => x.DataCriacao)
            .IsRequired()
            .HasColumnName("DataCriacao")
            .HasColumnType("SMALLDATETIME")
            .HasMaxLength(60);
            //.HasDefaultValue(DateTime.Now.ToUniversalTime());
            //.HasDefaultValueSql("GETDATE()");



            // Índices
            builder
                .HasIndex(x => x.Nome, "IDX_FormaDePagamento")
                .IsUnique();
        }
    }

}

