using RM.Aula.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Infra.Data.EntityConfig
{
    public class PaisConfig : EntityTypeConfiguration<Pais>
    {
        public PaisConfig()
        {
            HasKey(p => p.Id);
            ToTable("Paises");
        }
    }
}
