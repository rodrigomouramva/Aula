using System;
namespace RM.Aula.Domain.Entities
{
    public class Cidade : EntityBase
    {
        public string Cidades { get; set; }
        public Guid IdEstado { get; set; }
        public Estado Estados { get; set; }
    }
}
