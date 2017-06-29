using RM.Aula.Domain.Entities;
using RM.Aula.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Infra.Data.Context
{
    public class AulaContext : DbContext
    {
        public AulaContext(): base("DefaultConnection")
        {                
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        //public DbSet<Estado> Estados { get; set; }
        //public DbSet<Cidade> Cidades { get; set; }
        //public DbSet<Pais> Paises { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            //modelBuilder.Configurations.Add(new CidadeConfig());
            //modelBuilder.Configurations.Add(new EstadoConfig());
            //modelBuilder.Configurations.Add(new PaisConfig());

            modelBuilder.Properties<string>()
                .Configure(x => x.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(x => x.HasMaxLength(100));

            base.OnModelCreating(modelBuilder);
        }
    }
}
