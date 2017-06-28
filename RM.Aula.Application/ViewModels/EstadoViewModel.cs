using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RM.Aula.Application.ViewModels
{
    public class EstadoViewModel
    {
        public EstadoViewModel()
        {
            Id = Guid.NewGuid();     
        }
        
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Preencha a Sigla")]
        [MaxLength(8, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string Sigla { get; set; }
        [Required(ErrorMessage = "Preencha a Descrição do estado")]
        [MaxLength(20, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(20, ErrorMessage = "Mínimo {0} caracteres")]
        public string Descricao { get; set; }
        [ScaffoldColumn(false)]
        public Guid IdPais { get; set; }
        public virtual PaisViewModel Pais { get; set; }
        public virtual IEnumerable<CidadeViewModel> Cidades { get; set; }
    }
}