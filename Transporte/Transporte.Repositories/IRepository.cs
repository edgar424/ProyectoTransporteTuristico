using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.Repositories
{
    public interface IRepository<T> where T:class
    {
        void Delete(T entity);
        void Update(T entity);
        void Insert(T entity);

        IEnumerable<T> GetList();
        T GetById(int ind);

        int Count();
    }
}
