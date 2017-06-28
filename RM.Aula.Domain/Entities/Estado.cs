using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Domain.Entities
{
    public class Estado : EntityBase
    {
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public Guid IdPais { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual Cidade Cidades { get; set; }
    }
}
