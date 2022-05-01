using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public interface IService<T> where T : class
    {
        T GetById(int id);
        List<T> GetAll();
        List<T> GetBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(T entity);
        void DeleteRange(List<T> entities);
        bool Any(Expression<Func<T, bool>> prediceate);
    }
}
