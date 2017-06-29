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
            HasRequired(c => c.Estados)
                .WithMany(e => e.Cidades)
                .HasForeignKey(c => c.IdEstado);
            ToTable("Cidades");
        }
    }
}
