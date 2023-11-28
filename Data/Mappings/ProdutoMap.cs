using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vendas.Models;


namespace Vendas.Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            // Tabela
            builder.ToTable("Produto");

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
            builder.Property(x => x.Preco)
                .IsRequired()
                .HasColumnName("Preco")
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
                .HasIndex(x => x.Nome, "IDX_NOME")
                .IsUnique();
        }
    }
}
