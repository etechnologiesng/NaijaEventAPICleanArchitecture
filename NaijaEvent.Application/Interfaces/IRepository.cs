using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NaijaEvent.Application.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
           Task<  TEntity> Get(Guid id);
           Task<IEnumerable<TEntity>> GetAll();
           Task< IEnumerable<TEntity> >FindAsync(Expression<Func<TEntity, bool>> predicate);

            // This method was not in the videos, but I thought it would be useful to add.
          //  TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

            Task Add(TEntity entity);
          //  void AddRange(IEnumerable<TEntity> entities);

            Task Remove(TEntity entity);
            //void RemoveRange(IEnumerable<TEntity> entities);
        }
}
