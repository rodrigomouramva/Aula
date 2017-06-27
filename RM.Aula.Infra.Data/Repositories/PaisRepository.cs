using RM.Aula.Domain.Entities;
using RM.Aula.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Infra.Data.Repositories
{
    public class PaisRepository : Repository<Pais>, IPaisRepository
    {
        public IEnumerable<Pais> ObterPais()
        {
            return Buscar(p => p.Id != null);
        }
    }
}
