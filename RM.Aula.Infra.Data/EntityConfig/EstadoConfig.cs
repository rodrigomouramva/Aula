using RM.Aula.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
