using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Domain.Entities
{
    public class Cidade : EntityBase
    {
        public string Cidades { get; set; }
        public Guid IdEstado { get; set; }
        public Estado Estados { get; set; }
    }
}
