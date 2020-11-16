using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaceses
{
   public interface IShopReposytory<TEntity> : IGenericRepository<TEntity> where TEntity : Shop
    {
        public Task<IEnumerable<TEntity>> GetByName(string name);
    }
}
