using System.Collections;
using System.Collections.Generic;

namespace RM.Aula.Domain.Entities
{
    public class Pais : EntityBase
    {
        
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Estado> Estados { get; set; }
    }
}
