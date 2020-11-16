using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaceses
{
<<<<<<< HEAD
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        public Task<TEntity> FindById(long id);
        public Task<IEnumerable<TEntity>> Get();
=======
   public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity FindById(long id);
        IEnumerable<TEntity> Get();
>>>>>>> 1d0166b709d4b0466e20656b5fbf2d57d96a8618
    }
}
