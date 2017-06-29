using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Domain.Entities
{
    public class Estado : EntityBase
    {
        public Guid IdPais { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public virtual Pais Paises { get; set; }
    }
}
