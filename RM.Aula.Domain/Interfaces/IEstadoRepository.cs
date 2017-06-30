using RM.Aula.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Domain.Interfaces
{
    public interface IEstadoRepository : IRepository<Estado>
    {
        IEnumerable<Estado> ObterEstado(Guid id);
    }
}
