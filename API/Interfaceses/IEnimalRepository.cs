using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaceses
{
    public interface IEnimalRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Animal
    {
        public Task<IEnumerable<Animal>> GetByBreed(string breed);
    }
}
