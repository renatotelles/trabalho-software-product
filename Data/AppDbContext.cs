using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Vendas.Data.Mappings;
using Vendas.Models;

namespace Vendas.Data
{
    public class AppDbContext : DbContext
    {

        //public DbSet<Pessoa> Pessoas{ get; set; }

        public DbSet<Cliente> Clientes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            const string ConnectionString = @"Server = localhost\SQL2022; Database = Vendas; Integrated Security=SSPI;TrustServerCertificate=True";
            //const string ConnectionString = @"Server = localhost\SQL2022; Database = Vendas; User ID = sa; Password = sysadm; Encrypt=true";

            //User ID = sa; Password = sysadm";
            options.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());

        }

    }
}
