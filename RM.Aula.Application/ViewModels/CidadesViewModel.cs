using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Application.ViewModels
{
    public class CidadesViewModel
    {
        public CidadesViewModel()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid IdEstado { get; set; }
        public string Descricao { get; set; }
        public virtual EstadoViewModel Estados { get; set; }
    }
}
