using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vendas.Models;

namespace Vendas.Data.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            // Tabela
            builder.ToTable("Cliente");

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
            builder.Property(x => x.Endereco)
                .IsRequired()
                .HasColumnName("Endereco")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);
            
            // Propriedades
            builder.Property(x => x.Cidade)
                .IsRequired()
                .HasColumnName("Cidade")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);

            // Propriedades
            builder.Property(x => x.Uf)
                .IsRequired()
                .HasColumnName("Uf")
                .HasColumnType("VARCHAR")
                .HasMaxLength(2);


            builder.Property(x => x.DataCriacao)
            .IsRequired()
            .HasColumnName("DataCriacao")
            .HasColumnType("SMALLDATETIME")
            .HasMaxLength(60);
            //.HasDefaultValue(DateTime.Now.ToUniversalTime());
            //.HasDefaultValueSql("GETDATE()");



            // Índices
            builder
                .HasIndex(x => x.Nome, "IX_Todo_Name")
                .IsUnique();
        }
    }
}
