using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Store.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.Interfaces
{
    public interface IUnitWork
    {
        IGenericRepositroy<TEntity,Tkey> Repositroy <TEntity,Tkey>()where TEntity : BaseEntity<Tkey>;
            Task<int> CompleteAsync();
    }
}
