using Microsoft.EntityFrameworkCore;
using Store.Data.Contexts;
using Store.Data.Model;
using Store.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.Repositories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepositroy<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        private readonly StoreDbContexts _contexts;

        public GenericRepository(StoreDbContexts contexts)
        {
            _contexts = contexts;
        }
        public async Task AddAsync(TEntity entity)
        {
           await _contexts.AddAsync(entity);
        }

        public void DeleteAsync(TEntity entity)
        =>
           _contexts.Remove(entity);

        public async Task<IReadOnlyList<TEntity>> GetALLAsNoTrackingAsync()

       => await _contexts.Set<TEntity>().AsNoTracking().ToListAsync();

        public async Task<IReadOnlyList<TEntity>> GetAllAsync()
        
       =>    await _contexts.Set<TEntity>().ToListAsync();

        public async Task<TEntity> GetByIdAsNoTrackingAsync(TKey? id)
             => await _contexts.Set<TEntity>().AsNoTracking().FirstAsync();
        public async Task<TEntity> GetByIdAsync(TKey? id)
        
          =>  await _contexts.Set<TEntity>().FirstAsync();
        

        public void UpdateAsync(TEntity entity)
        
        =>_contexts.Set<TEntity>().Update(entity);

        Task IGenericRepositroy<TEntity, TKey>.DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        Task IGenericRepositroy<TEntity, TKey>.UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
