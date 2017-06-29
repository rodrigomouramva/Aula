using RM.Aula.Domain.Entities;
using RM.Aula.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Infra.Data.Repositories
{
    public class EstadoRepository : Repository<Estado>, IEstadoRepository
    {
        //public IEnumerable<Estado> ObterEstado()
        //{
        //    return Buscar(e => e.Id != null);
        //}
    }
}
