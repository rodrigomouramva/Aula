using RM.Aula.Domain.Entities;
using RM.Aula.Domain.Interfaces;
using RM.Aula.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
namespace RM.Aula.Infra.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        protected AulaContext Db;
        protected DbSet<TEntity> DbSet;
        public Repository()
        {
            Db = new AulaContext();
            DbSet = Db.Set<TEntity>();
        }
        public TEntity Adicionar(TEntity obj)
        {
            var entity = DbSet.Add(obj);
            SaveChanges();
            return entity;
        }
        public TEntity Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            SaveChanges();
            return obj;
        }
        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }
        public void Dispose()
        {
            Db.Dispose();
        }
        public IEnumerable<TEntity> ObterPaginado(int s, int t)
        {
            return DbSet.Skip(s).Take(t);
        }
        public TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }
        public IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }
        public void Remover(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
            SaveChanges();
        }
        public int SaveChanges()
        {
            return Db.SaveChanges();
        }
    }
}
