using System;
using System.Collections.Generic;
namespace RM.Aula.Domain.Entities
{
    public class Estado : EntityBase
    {
        public Estado()
        {
            Cidades = new List<Cidade>();
        }

        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public Guid IdPais { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
