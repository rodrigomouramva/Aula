﻿using System;

namespace RM.Aula.Domain.Entities
{
    public class Endereco : EntityBase
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Guid ClienteId { get; set; }
        // Propriedade de Navegacao do EF
        public virtual Cliente Cliente { get; set; }
    }
}