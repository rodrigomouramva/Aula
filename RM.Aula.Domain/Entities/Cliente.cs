using System;
using System.Collections.Generic;
namespace RM.Aula.Domain.Entities
{
    public class Cliente : EntityBase
    {
        public Cliente()
        {
            Enderecos = new List<Endereco>();
        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public bool Excluido { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
