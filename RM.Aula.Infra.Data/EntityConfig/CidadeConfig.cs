using RM.Aula.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace RM.Aula.Infra.Data.EntityConfig
{
    public class CidadeConfig : EntityTypeConfiguration<Cidade>
    {
        public CidadeConfig()
        {
            HasKey(c => c.Id);           
            HasRequired(e => e.Estados)
               .WithMany(c => c.Cidades)
               .HasForeignKey(e => e.IdEstado);
            ToTable("Cidades");
        }
    }
}
