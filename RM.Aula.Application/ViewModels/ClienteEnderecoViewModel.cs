﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Application.ViewModels
{
    public class ClienteEnderecoViewModel
    {
        public ClienteViewModel Cliente { get; set; }
        public EnderecoViewModel Endereco { get; set; }

        public PaisViewModel Pais { get; set; }
        public EstadoViewModel Estado { get; set; }
    }
}
