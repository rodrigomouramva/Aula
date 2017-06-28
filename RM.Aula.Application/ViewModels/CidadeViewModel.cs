using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Application.ViewModels
{
    public class CidadeViewModel
    {
        //public CidadeViewModel()
        //{
        //    Id = Guid.NewGuid();
        //}
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Preencha a cidade")]
        [MaxLength(30, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(30, ErrorMessage = "Mínimo {0} caracteres")]
        public string Cidades { get; set; }
        [ScaffoldColumn(false)]
        public Guid IdEstado { get; set; }
        public EstadoViewModel Estados { get; set; }
    }
}
