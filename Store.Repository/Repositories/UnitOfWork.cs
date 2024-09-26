using Store.Data.Contexts;
using Store.Data.Model;
using Store.Repository.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.Repositories
{
    public class UnitOfWork : IUnitWork
    {
        private readonly StoreDbContexts _contexts;
        private Hashtable _repositroies;

        public UnitOfWork(StoreDbContexts contexts)
        {
            _contexts = contexts;
        }

        public async Task<int> CompleteAsync()
        
         =>   await _contexts.SaveChangesAsync();

        public IGenericRepositroy<TEntity, Tkey> Repositroy<TEntity, Tkey>() where TEntity : BaseEntity<Tkey>
        {
            if(_repositroies is null)
                _repositroies = new Hashtable();
            var entityKey=typeof(TEntity).Name;

            if(!_repositroies.ContainsKey(entityKey))
            {
                var repositoryType=typeof(GenericRepository<,>);

                var repositoryInstance=Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity),typeof(Tkey)),_contexts);
                _repositroies.Add(entityKey, repositoryInstance);
            }
            return (IGenericRepositroy<TEntity, Tkey>)_repositroies[entityKey];
        }
    }
}
