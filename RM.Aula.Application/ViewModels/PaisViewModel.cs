using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Application.ViewModels
{
    public class PaisViewModel
    {
        public PaisViewModel()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public virtual IEnumerable<EstadoViewModel> Estados { get; set; }
    }
}
