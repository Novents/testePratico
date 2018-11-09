using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using TestePratico.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TestePratico.Data
{
    public class TestePraticoContext : DbContext
    {
        public TestePraticoContext()
            : base("TestePratico_Desenv")
        {

        } 

        public DbSet<Estabelecimento> Estabelecimento { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<TestePratico.Models.Categoria> Categorias { get; set; }
    }
}