using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaceses
{
    public interface ITrainsReposytory<TEntity> : IGenericRepository<TEntity> where TEntity : Train
    {
        public Task<IEnumerable<TEntity>> GetByBrand(string name);
    }
}
