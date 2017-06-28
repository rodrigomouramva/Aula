using RM.Aula.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
