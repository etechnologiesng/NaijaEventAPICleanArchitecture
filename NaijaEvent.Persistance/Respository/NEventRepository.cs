using Microsoft.EntityFrameworkCore;
using NaijaEvent.Application.Interfaces;
using NaijaEvent.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NaijaEvent.Persistance.Respository
{
    class NEventRepository : INEventRepository
    {
        protected readonly DbContext Context;

        public NEventRepository(DbContext context)
        {
            Context = context;
        }

        public async Task<TEntity> Get(int id)
        {
            // Here we are working with a DbContext, not PlutoContext. So we don't have DbSets 
            // such as Courses or Authors, and we need to use the generic Set() method to access them.
            return await Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            // Note that here I've repeated Context.Set<TEntity>() in every method and this is causing
            // too much noise. I could get a reference to the DbSet returned from this method in the 
            // constructor and store it in a private field like _entities. This way, the implementation
            // of our methods would be cleaner:
            // 
            // _entities.ToList();
            // _entities.Where();
            // _entities.SingleOrDefault();
            // 
            // I didn't change it because I wanted the code to look like the videos. But feel free to change
            // this on your own.
            return Context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

      

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

     

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        //public async Task RemoveRange(IEnumerable<TEntity> entities)
        //{
        //    await Context.Set<TEntity>().RemoveRange(entities);
        //}

       public async Task<NEvent> IRepository<NEvent> Get (Guid id)
        {
           await throw new NotImplementedException();
        }

        IEnumerable<NEvent> IRepository<NEvent>.GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NEvent> Find(Expression<Func<NEvent, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public NEvent SingleOrDefault(Expression<Func<NEvent, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(NEvent entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<NEvent> entities)
        {
            throw new NotImplementedException();
        }

        public void Remove(NEvent entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<NEvent> entities)
        {
            throw new NotImplementedException();
        }
    }
}
