using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Domain.Entities
{
    public class Pais : EntityBase
    {
        public Pais()
        {
            Estados = new List<Estado>();
        }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Estado> Estados { get; set; }
    }
}
