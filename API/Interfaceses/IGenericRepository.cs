using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaceses
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        public Task<TEntity> FindById(long id);
        public Task<IEnumerable<TEntity>> Get();
    }
}
