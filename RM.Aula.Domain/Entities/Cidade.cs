using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Domain.Entities
{
    public class Cidade : EntityBase
    {        
        public Guid IdEstado { get; set; }
        public string Descricao { get; set; }
        public virtual Estado Estados { get; set; }
    }
}
