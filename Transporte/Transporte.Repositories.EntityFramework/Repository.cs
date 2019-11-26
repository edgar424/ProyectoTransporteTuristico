using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Transporte.Repositories.EntityFramework
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        protected TransporteDBContext TransporteDBContext
        {
            get { return Context as TransporteDBContext; }
        }

        public Repository(DbContext context)
        {
            Context = context;
        }

        public void Insert(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public TEntity GetById(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetList()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public int Count()
        {
            return Context.Set<TEntity>().Count();
        }

        public void Update(TEntity entity)
        {
            Context.Entry<TEntity>(entity).State = EntityState.Modified;
        }

    }
}
