using API.Entities;
using API.Interfaceses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace API.Data.Reposytory
{
<<<<<<< HEAD
    public class AnimalRepository : IEnimalRepository<Animal>//IGenericRepository<TEntity> where TEntity : class
    {
        DataContext _dataContext;
        public AnimalRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Animal> FindById(long id) => await _dataContext.Animals.SingleOrDefaultAsync(X=>X.Id==id);
        public async Task<IEnumerable<Animal>> Get() => await _dataContext.Animals.ToListAsync();
        public async Task<IEnumerable<Animal>> GetByBreed(string breed) => await _dataContext.Animals.Where(x=>x.Breed == breed).ToListAsync();
=======
    public class AnimalRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        DataContext _dataContext;
        DbSet<TEntity> _dbSet;
        public AnimalRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
            _dbSet = dataContext.Set<TEntity>();
        }

        public TEntity FindById(long id) =>_dbSet.Find(id);
        public IEnumerable<TEntity> Get() =>_dbSet.AsNoTracking().ToList();
>>>>>>> 1d0166b709d4b0466e20656b5fbf2d57d96a8618
    }
}
