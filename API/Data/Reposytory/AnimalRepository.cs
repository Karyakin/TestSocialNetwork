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
    }
}
