using RM.Aula.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace RM.Aula.Infra.Data.EntityConfig
{
    public class EstadoConfig : EntityTypeConfiguration<Estado>
    {
        public EstadoConfig()
        {
            HasKey(e => e.Id);
           
            HasRequired(e => e.Pais)
               .WithMany(c => c.Estados)
               .HasForeignKey(e => e.IdPais);
            ToTable("Estados");
        }
    }
}
