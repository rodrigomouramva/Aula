using RM.Aula.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Application.Interfaces
{
    public interface IPaisAppService
    {
       IEnumerable<PaisViewModel> ObteTodos();

    }
}
