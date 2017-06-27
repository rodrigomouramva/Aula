using RM.Aula.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RM.Aula.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : EntityBase
    {
        TEntity Adicionar(TEntity obj);
        TEntity ObterPorId(Guid id);
        TEntity Atualizar(TEntity obj);
        IEnumerable<TEntity> ObterTodos();
        IEnumerable<TEntity> ObterPaginado(int s, int t);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        void Remover(Guid id);
        int SaveChanges();
    }
}
