using Store.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.Interfaces
{
    public interface IGenericRepositroy<TEntity,TKey> where TEntity : BaseEntity<TKey>
    {
        Task <TEntity> GetByIdAsync(TKey? id);
        Task <IReadOnlyList<TEntity>>GetAllAsync();
  Task<IReadOnlyList<TEntity>> GetALLAsNoTrackingAsync();
        Task<TEntity> GetByIdAsNoTrackingAsync(TKey? id);
        Task AddAsync(TEntity entity );
        Task DeleteAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);


    }
}
