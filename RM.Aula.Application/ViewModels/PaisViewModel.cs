using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Application.ViewModels
{
    public class PaisViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Preencha a Sigla")]
        [MaxLength(8, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string Sigla { get; set; }

        [Required(ErrorMessage = "Preencha o Pais")]
        [MaxLength(20, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(20, ErrorMessage = "Mínimo {0} caracteres")]
        public string Descricao { get; set; }
        public virtual EstadoViewModel Estados { get; set; }
    }
}
